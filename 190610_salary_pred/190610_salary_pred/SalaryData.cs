using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190610_salary_pred
{
    public class SalaryData
    {
        [Column("0")]
        public float YILLAR;

        [Column("1", name: "Label")]
        public float MAAS;
    }
}
