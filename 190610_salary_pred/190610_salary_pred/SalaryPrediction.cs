using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190610_salary_pred
{
    public class SalaryPrediction
    {
        [ColumnName("Score")]
        public float PredictedSalary;

        // Maaş tahmininin başarısı
    }
}
