using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Models;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190610_classification_mlnet
{
    public class ProcessData
    {
        [Column("0")]
        public float UnitA;

        [Column("1")]
        public float UnitS;

        [Column("2")]
        public float Volume;

        [Column("3")]
        [ColumnName("Label")]
        public string Label;
    }
    public class ProcessPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var trainData = GeneratePData(2000);
            Print(trainData.Take(20));
            var testData = GeneratePData(50, test: true);

            // ML görevi için obje oluşturur
            var learningPipe = new LearningPipeline();
            var trainCollection = CollectionDataSource.Create(trainData);
            learningPipe.Add(trainCollection);
            // Verilerin kolon isimleri olan labelları numeric indexe çevirir.
            learningPipe.Add(new Dictionarizer("Label"));

            learningPipe.Add(
                new ColumnConcatenator("Features", "UnitA", "UnitS", "Volume"));

            // Algoritma sınıflandırması
            learningPipe.Add(new StochasticDualCoordinateAscentClassifier());

            // Tahmin edilen kolon değerini çevir 
            learningPipe.Add(new PredictedLabelColumnOriginalValueConverter()
            { PredictedLabelColumn = "PredictedLabel" });

            // Modeli eğitme
            var model = learningPipe.Train<ProcessData, ProcessPrediction>();

            // Model değerlendirilmesi ve kesin kontrol
            var evaluator = new ClassificationEvaluator();
            var metrics = evaluator.Evaluate(model, trainCollection);
            Console.WriteLine("AccuracyMicro: " + metrics.AccuracyMicro);
            Console.WriteLine("LogLoss: " + metrics.LogLoss);

            // Test datayı tahmin et
            var predicted = model.Predict(testData);

            // Testdata ve tahmin edilen labelı string içinde topla 
            var results = testData.Zip(predicted, (t, p) => new ProcessData
            {
                UnitA = t.UnitA,
                UnitS = t.UnitS,
                Volume = t.Volume,
                Label = p.PredictedLabels

            }).ToList();

            // Sonucu yazdır  
            Print(results);

            Console.ReadLine();

        }
        //Random veri oluşturan metod. Classtan kolonları çekip listeye atarak random bir şekilde veri oluşturur ve veri değerlerine göre sınıflandırma yapar.

        private static List<ProcessData> GeneratePData(int count, bool test = false)
        {
            var pdlist = new List<ProcessData>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                var pd = new ProcessData
                {
                    UnitA = random.Next(0, 120),
                    UnitS = random.Next(0, 60),
                    Volume = random.Next(40, 280)
                };

                if (!test)
                {
                    if ((pd.UnitA > 75 || pd.UnitS > 30) && pd.Volume > 230)
                        pd.Label = "Warning";
                    else if ((pd.UnitA < 25 || pd.UnitS < 20) && pd.Volume < 100)
                        pd.Label = "Alert";
                    else
                        pd.Label = "Normal";
                }
                else
                    pd.Label = string.Empty;

                pdlist.Add(pd);
            }
            return pdlist;
        }
            // Random oluşturulan verileri yazdıran metod
            private static void Print(IEnumerable<ProcessData> results)
            {
            int i = 1;
            Console.WriteLine("id,UnitA,UnitS,Volume,Label");
            foreach (var item in results)
            {
                Console.WriteLine(string.Join(",", i,
                                  item.UnitA, item.UnitS, item.Volume, item.Label));
                i++;
            }
        }
    }
}
