using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SporMagazasi.Models.Model
{
    public class Siparis
    {

        public int SiparisID { get; set; }

        public string UrunId { get; set; }

        public int KategoriId { get; set; }

        public int UserID { get; set; }

        //public virtual Urun Sinif { get; set; }
    }
}