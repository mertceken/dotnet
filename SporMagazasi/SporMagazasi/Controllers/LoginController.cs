using SporMagazasi.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SporMagazasi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(SporMagazasi.Models.Model.User model)
        {
            if (ModelState.IsValid)
            {
                if (model.IsValid(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

                    return RedirectToAction("/Admin/AdminIndex");

                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }


            return View(model);
        }


    }
}