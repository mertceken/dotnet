using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_Layer
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool Gender { get; set; }

        public string IdentityNumber { get; set; }

        public decimal AnnualSalary { get; set; }

        public int ContractID { get; set; }
    }
}