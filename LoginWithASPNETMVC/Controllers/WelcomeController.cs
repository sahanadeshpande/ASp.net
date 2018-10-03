using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginWithASPNETMVC.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Logout()
        {

           
                //   ViewBag.Error = "Enter username and password";
                Session["Username"] = null;
                return View("Index");
            
        }
}
    }