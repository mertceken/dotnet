using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace SporMagazasi
{
    public class ProductModel
    {
        public string Name { get; set; }
        public IEnumerator<SelectListItem> Kategoriler { get; set; }
    }
}