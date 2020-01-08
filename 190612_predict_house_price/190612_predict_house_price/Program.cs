using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace _190612_predict_house_price
{

    public class HouseData
    {
        public float Size { get; set; }
        public float Price { get; set; }
        public float City { get; set; }
    }

    // Verilerimin kolonlarını tanıyacak bir yapı için class oluşturmam gerekiyor. HouseData classıyla buna başladım.

    public class Prediction
    {
        [ColumnName("Score")]
        public float Price { get; set; }
    }

    // Prediction classı tahmin değerini tutacak

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Cities = new Dictionary<int, string>()
        {
            { 1,"İstanbul"},
            { 2,"Ankara"}
        };

            MLContext mlContext = new MLContext();

            // Datasetin bilgilerini classtan alıp bir diziye atarak oluşturduk.. 4 satırlı

            HouseData[] houseData = {
               new HouseData() { Size = 1.1F, Price = 0.5F, City = 1F },
               new HouseData() { Size = 1.9F, Price = 3.0F, City = 2F },
               new HouseData() { Size = 2.8F, Price = 1.2F, City = 1F},
               new HouseData() { Size = 3.4F, Price = 4.1F, City = 2F } };
            IDataView trainingData = mlContext.Data.LoadFromEnumerable(houseData);

            //  Specify data preparation and model training pipeline

            var pipeline = mlContext.Transforms.Concatenate("Features", new[] { "Size", "City" })
               .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Price", maximumNumberOfIterations: 100));

            // Modeli eğitiyoruz

            var model = pipeline.Fit(trainingData);

            // Tahmin yapıyoruz 

            var size = new HouseData() { Size = 2.5F, City = 1F };
            var size2 = new HouseData() { Size = 2.1F, City = 2F };

            var price = mlContext.Model.CreatePredictionEngine<HouseData, Prediction>(model).Predict(size);
            var price2 = mlContext.Model.CreatePredictionEngine<HouseData, Prediction>(model).Predict(size2);

            Console.WriteLine($"Predicted price for size: {size.Size * 100} m2 ft= {price.Price * 100:C}k In the {Cities[Convert.ToInt32(size.City)]}");
            Console.WriteLine($"Predicted price for size: {size.Size * 100} m2 ft= {price2.Price * 100:C}k In the {Cities[Convert.ToInt32(size2.City)]}");
            Console.ReadKey();
        }
    }
}
