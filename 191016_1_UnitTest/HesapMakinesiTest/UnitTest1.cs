using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HesapMakinesiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Topla()
        {
            HesapMakinesi.Hesapla hesapla = new HesapMakinesi.Hesapla();

            int sonuc = hesapla.topla(10,20);
            // BEKLENEN SONUÇ = 30..

            Assert.AreEqual(30, sonuc);

        }
        [TestMethod]
        public void Cikar()
        {
            HesapMakinesi.Hesapla hesapla = new HesapMakinesi.Hesapla();
            int sonuc = hesapla.cikar(20, 10);
            // BEKLENEN SONUÇ = 10..

            Assert.AreEqual(10, sonuc);
        }

        [TestMethod]
        public void Bol()
        {
            HesapMakinesi.Hesapla hesapla = new HesapMakinesi.Hesapla();
            int sonuc = hesapla.bol(20, 10);
            // BEKLENEN SONUÇ = 2..

            Assert.AreEqual(2, sonuc);
        }

        [TestMethod]
        public void Carp()
        {
            HesapMakinesi.Hesapla hesapla = new HesapMakinesi.Hesapla();
            int sonuc = hesapla.carp(20, 10);
            // BEKLENEN SONUÇ = 200..

            Assert.AreEqual(200, sonuc);
        }
    }
}
