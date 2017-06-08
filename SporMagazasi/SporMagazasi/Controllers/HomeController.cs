using SporMagazasi.Models.Context;
using SporMagazasi.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SporMagazasi.Models;
namespace SporMagazasi.Controllers
{
    public class HomeController : Controller
    {
        SporMagazasiDb db = new SporMagazasiDb();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Spor()
        {
            return View();
        }
         public ActionResult Avcilik()
        {
            List<Product> plist = db.Products.Where(x=>x.CategoryId==1).ToList();
            return View(plist);
        }

         public ActionResult Balikcilik()
         {
             List<Product> blist = db.Products.Where(x => x.CategoryId==2).ToList();
             return View(blist);
         }
        public ActionResult Yuzme()
        {
            List<Product> ylist = db.Products.Where(x=>x.CategoryId==3).ToList();
            return View(ylist);
        }
        public ActionResult Voleybol()
        {
            List<Product> ylist = db.Products.Where(x=>x.CategoryId==4).ToList();
            return View(ylist);
        }
        public ActionResult Basketbol()
        {
            List<Product> ylist = db.Products.Where(x=>x.CategoryId==5).ToList();
            return View(ylist);
        }
        
    }
}