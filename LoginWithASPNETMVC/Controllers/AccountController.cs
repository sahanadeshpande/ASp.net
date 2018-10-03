using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginWithASPNETMVC.ViewModels;

namespace LoginWithASPNETMVC.Controllers
{
    public class AccountController : Controller
    {
      public ActionResult Index()
        {
                  
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {

            if(avm.account.Username==null && avm.account.PassWord==null )
            {
               ViewBag.Error = "Enter username and password";
                Session["Username"] = null;
                return View("Index");
            }

         else if (avm.account.Username.Equals("abc") && avm.account.PassWord.Equals("123"))
            {
                Session["Username"] = avm.account.Username;
                return View("Welcome");
            }
            else 
            {
                ViewBag.Error = "Invalid User";
                return View("Index");
            }
          
      
        }


    }
}