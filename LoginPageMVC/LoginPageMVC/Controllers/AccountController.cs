using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginPageMVC.ViewModels;


namespace LoginPageMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            AccountViewModel avm = new AccountViewModel();

            return View();
        }

        [HttpPost]

        public ActionResult Login(AccountViewModel avm)
        {
            if(avm.Account.Username.Equals("abc") && avm.Account.Username.Equals("123"))
            {
                Session["username"] = avm.Account.Username;
                return View("Welcome");

            }
            else
            {
                ViewBag.Error = "Account's Invalid";
               return View();
            }
            
        }

        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}