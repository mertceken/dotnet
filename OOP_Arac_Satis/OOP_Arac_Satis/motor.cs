﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arac_Satis
{
    class motor:tasit
    {
        public override double KDVhesapla()
        {
            return fiyat * 1.25;
        }
    }
}
