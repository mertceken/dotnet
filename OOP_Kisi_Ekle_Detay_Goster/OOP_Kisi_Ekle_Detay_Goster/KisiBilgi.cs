using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kisi_Ekle_Detay_Goster
{
    class KisiBilgi
    {

        public string kisiadi { get; set; }
        public string  kisisoyad { get; set; }
        public string dogumyeri { get; set; }
        public string babaadi { get; set; }

        public DateTime dogumtarih { get; set; }

        public override string ToString()
{
 	 return kisiadi;
}
    }
}
