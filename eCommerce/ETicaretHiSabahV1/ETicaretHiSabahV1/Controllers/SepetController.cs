using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ETicaret.BLL;
using ETicaret.DLL;

namespace ETicaretHiSabahV1.Controllers
{
    public class SepetController : Controller
    {
        // GET: Sepet
        public ActionResult SepetIndex()
        {
            /*
             https://bootsnipp.com/snippets/ZXKKD ETicaret sepet kısmı bu linkten alındı
                */        
            return View(SepetiGetir());
        }

        public ActionResult SepeteEkle(int UrunlerID)//HiddenFor ile gönderilen ID değeri veritabanındaki ID kolonlu isim ile gönderiliyor. Bu parametre de Veritabanındaki isim ile aynı olmalıdır
        {
            //ilk önce sepet getirilecek ve getirilen sepete ürüne eklemesi yapılacak
            SepetiGetir().SepeteUrunEkle(UrunlerID, 1);

            return RedirectToAction("SepetIndex");
        }
        public ActionResult SepettenAzalt(int UrunlerID)
        {

            SepetiGetir().SepetUrunAzalt(UrunlerID);
            return RedirectToAction("SepetIndex");
        }
        public ActionResult SepettenSil(int urunler_Id)
        {
            SepetiGetir().UrunuSeppettenSil(urunler_Id);
            return RedirectToAction("SepetIndex");
        }

        public SepetManager SepetiGetir()
        {
            //SepetManager class'ını bir Session da tutup kontrolünü sağlayacağız
            var SepetOlustur = (SepetManager)Session["SepetManager"];//varsayılan olarak ilk oluştyrduğumuz değişken bu olduğundan şu an içi boştur

            if (SepetOlustur==null)
            {
                //Session["SepetManager"] ilk boş geldiğinden SepetManager() class'ından örnek alarak oluşturuyorum
                SepetOlustur = new SepetManager();
                Session["SepetManager"] = SepetOlustur;
            }
            return SepetOlustur;
        }
    }
}