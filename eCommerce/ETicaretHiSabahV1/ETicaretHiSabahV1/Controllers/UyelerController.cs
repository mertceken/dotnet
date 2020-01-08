using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ETicaret.BLL;
using ETicaret.DLL;

namespace ETicaretHiSabahV1.Controllers
{
    public class UyelerController : Controller
    {
        // GET: Uyeler
        public ActionResult UyelerIndex()
        {
            return View();
        }

        UyeManager uyeMan = new UyeManager();

        [HttpPost]
        public ActionResult UyelerIndex(string UyeAdi,string Email,string  Sifre,string Sifre_Tekrar)
        {
            if (Sifre!=Sifre_Tekrar)
            {
                ViewBag.SifreAynimi = "Şifreler Uyuşmuyor";
                return View();
            }
            else
            {
                DateTime tarih = DateTime.Now;
                uyeMan.UyeKaydet(UyeAdi, null,Convert.ToDateTime(tarih.ToShortDateString()), Email, null,null, null, null,"", Email, Sifre);
                //return View();
                //return RedirectToAction("YorumIndex", "Yorum");
                return RedirectToAction("DefaultIndex", "Default");
                //RedirectToAction ile Index adı ve klasör adı vererek, kalsör altındaki Index i çalıştırmasını sağlıyoruz.
                //Bu RedirectToAction aldığı parametre ile Controller altındak ActionName parametre alır, ikinci parametresi ise Controller adını alarak aynı klasör mantığında olduğu gibi Index sayfası çalıştırır
            }
        }

        public ActionResult UyeGirisIndex()
        {
            return View();
        }


        [HttpPost]
        public ActionResult UyeGirisIndex(string KullaniciAdi,string KullaniciSifre)
        {
            var login = uyeMan.UyeGiris(KullaniciAdi, KullaniciSifre);

            if (login!=null)
            {
                Session["isim"] = login.UyeAdi+" "+login.UyeSoyadi;
                return RedirectToAction("DefaultIndex", "Default");
            }

            ViewBag.LoginMesaj = "Kullanıcı Adı veya Şifreniz hatalı";
            return View();
        }


    }
}