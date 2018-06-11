using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            if (loginbutton == "Log In") { return PartialView("PV_Login"); }
            else if (loginbutton == "Create New") { return PartialView("PV_CreateAccount"); }
            else { return View("UserControl"); }

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