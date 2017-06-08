using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SporMagazasi.Models.Model
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string UnitPrice { get; set; }

        public string UnitStock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public bool isDeleted { get; set; }

        public string ImagePath { get; set; }
     
    }
}