using SporMagazasi.Models.Context;
using SporMagazasi.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SporMagazasi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        SporMagazasiDb db = new SporMagazasiDb();
        public ActionResult AdminIndex()
        {
            return View();
        }


        //1
        
        public ActionResult AddProduct()
        {
            ViewBag.CategoryId = new SelectList(db.Categorys, "CategoryId", "CategoryName");

           
           
            return View();
        }
        //2
         [HttpPost]
        public ActionResult AddProduct(Product prd, HttpPostedFile file)
        {
            try
            {


               
                if (ModelState.IsValid)
                {
                    if (file != null)
                    {
                        //Sunucuya dosya kaydedilirken, sunucunun dosya sistemini, yolunu bilemeyeceğimiz için
                        //Server.MapPath() ile sitemizin ana dizinine gelmiş oluruz. Devamında da sitemizdeki
                        //yolu tanımlarız.
                        file.SaveAs(Server.MapPath("~/img/") + file.FileName);
                        prd.ImagePath = "/img/" + file.FileName;
                    }
                    db.Products.Add(prd);
                    db.SaveChanges();
                    return RedirectToAction("/ProductList");
                }
                ViewBag.CategoryId = new SelectList(db.Categorys, "CategoryId", "CategoryName", prd.CategoryId);
                return View(prd);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Ekleme işlemi sırasında bir hata oluştu."); 
                return View(prd);
            }
            return View();
        }



        public ActionResult EditProduct(int id)
        {
            Product prd = db.Products.FirstOrDefault(x => x.ProductID == id);
            ViewBag.CategoryId = new SelectList(db.Categorys, "CategoryId", "CategoryName", prd.CategoryId);
            return View(prd);
        }

        [HttpPost]
        public ActionResult EditProduct(Product prd)
        {
            Product prd1 = db.Products.FirstOrDefault(x => x.ProductID == prd.ProductID);
            prd1.ProductName = prd.ProductName;
            prd1.UnitStock = prd.UnitStock;
            prd1.UnitPrice = prd.UnitPrice;
            prd1.CategoryId = prd.CategoryId;
            db.SaveChanges();
            return RedirectToAction("/ProductList");
        }

        public ActionResult ProductList()
        {
            List<Product> plist = db.Products.Where(x => x.isDeleted == false).ToList();

            return View(plist);
        }

        public ActionResult AddCategory()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            db.Categorys.Add(c);
            db.SaveChanges();
            return RedirectToAction("/CategoryList");

        }

        public ActionResult CategoryList()
        {
            List<Category> clist = db.Categorys.Where(x=>x.isDeleted ==false).ToList();

            return View(clist);
        }

        public JsonResult DeleteProduct(int id)
        {
            Product prd = db.Products.FirstOrDefault(x => x.ProductID == id);
            prd.isDeleted = true;
            db.SaveChanges();
            return Json(" ");
        }

        public JsonResult DeleteCategory(int id)
        {
            Category c = db.Categorys.FirstOrDefault(x => x.CategoryID == id);
            c.isDeleted = true;
            db.SaveChanges();
            return Json(" ");
        }

        public ActionResult EditCategory(int id)
        {
            Category c = db.Categorys.FirstOrDefault(x => x.CategoryID == id);
            return View(c);
        }

        [HttpPost]
        public ActionResult EditCategory(Category ct)
        {
            Category ct1 = db.Categorys.FirstOrDefault(x => x.CategoryID == ct.CategoryID);
            ct1.CategoryName = ct.CategoryName;
            ct1.Description = ct.Description;
           
            db.SaveChanges();
            return RedirectToAction("/CategoryList/");
        }

     

    }


}
