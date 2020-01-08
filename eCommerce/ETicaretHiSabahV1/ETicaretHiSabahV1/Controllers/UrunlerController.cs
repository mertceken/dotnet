using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ETicaret.BLL;
using ETicaret.DLL;



namespace ETicaretHiSabahV1.Controllers
{
    public class UrunlerController : Controller
    {
        UrunManager urunMan = new UrunManager();
        //*********************************************************
        ETicaretDBEntities db = new ETicaretDBEntities();
        //*********************************************************
        UrunYorumlariManager yorMan = new UrunYorumlariManager();
        // GET: Urunler
        public ActionResult UrunlerIndex()
        {
            return View();
        }

        
        public ActionResult UrunDetay()
        {
            //Ürünler sayfasında üründetay tıklandığında ürün Id değerini tutacak Route data kodlaması yapacağız
         var   dataId =RouteData.Values["id"];
            //var tututalIdsonuc = db.Urunler.Where(k => k.UrunlerID == Convert.ToInt32(dataId));
            var detay = urunMan.urunDetay(Convert.ToInt32(dataId));
            return View(detay);
        }

        public ActionResult UrunYorumIndex()
        {
            return View();
        }

        [HttpPost]
        public void UrunYorumIndex(string YorumBaslik, string YorumMetni, int? nameurunlerID, int? uyeId)
        {
            //Ekleme işlemi JavaAcript ile yapılacak
            yorMan.YorumKaydet(1,(int)nameurunlerID, YorumBaslik, YorumMetni, 0, Convert.ToDateTime(DateTime.Now.ToShortDateString()), 1, 1);
            
        }


    }
}