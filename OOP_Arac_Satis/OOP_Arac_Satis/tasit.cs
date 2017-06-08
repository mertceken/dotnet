using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arac_Satis
{
   abstract class tasit
    {
        public double fiyat { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string vitesTuru { get; set; }
        public string motorGucu { get; set; }
        public string renk { get; set; }
        public string yil { get; set; }

       public virtual double KDVhesapla()
        {
            return fiyat * 1.40;

        }

       public double VIP()
       {

           return KDVhesapla() * 0.95;
       }

       public double EngelliMusteri()
       {
           return KDVhesapla() * 0.50;
       }

       public override string ToString()
       {
           return marka ;
       }

       public double indirim(double oran)
       {
           return KDVhesapla() * oran;
       }
   }
}
