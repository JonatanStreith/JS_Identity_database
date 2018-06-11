using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using JS_Identity.Models;
using Microsoft.AspNet.Identity;

namespace JS_Identity.Controllers
{
    public class HomeController : Controller
    {






        // GET: Home
        public ActionResult Index()
        {
            return View();
        }





        public ActionResult UserControl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginOrCreate(string loginbutton)
        {
            if (loginbutton == "Existing User") { return PartialView("PV_Login"); }
            else if (loginbutton == "New User") { return PartialView("PV_CreateAccount"); }
            else { return View("UserControl"); }

        }

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult CreateAccount()
        {
            return View();
        }










        public ActionResult DisplayData()
        {
            return View();
        }

        public ActionResult EditData()
        {
            return View();
        }

        public ActionResult Other()
        {
            return View();
        }
    }
}