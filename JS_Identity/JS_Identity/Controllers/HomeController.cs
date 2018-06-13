using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using JS_Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using JS_Identity_Project;
using System.Threading.Tasks;

namespace JS_Identity.Controllers
{
    public class HomeController : Controller
    {
        private AppSignInManager _signInManager;
        private AppUserManager _userManager;



        public AppUserManager UM
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        public AppSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<AppSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }











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
            else if (loginbutton == "New User") { return PartialView("PV_CreateAccount", ""); }
            else { return View("UserControl"); }

        }

        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public async Task<ActionResult> CreateAccount(string name, string password)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser { Name = name, Email= "jonatan@streith.se" };
                UM.Create(user, password);
                
                
                    SignInManager.SignIn(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return PartialView("PV_CreateAccount", "Account created!");
                
            }

            // If we got this far, something failed, redisplay form
            return View();
        }





        //public ActionResult CreateAccount(string name, string password)
        //{

        //    //if (ModelState.IsValid)
        //    //{
        //    UM.Create(new AppUser { Name = name }, password);

        //    return PartialView("PV_CreateAccount", "Account created!");

        //}

        //}
        //else
        //{
        //    return PartialView("PV_CreateAccount", "Name or password in use.");
        //}




        //public ActionResult CreateAccount(string name, string password)
        //{

        //    bool success = LoginFunctions.CreateAccount(name, password);

        //    if (success) { return PartialView("PV_CreateAccount", "Account created!"); }
        //    else { return PartialView("PV_CreateAccount", "Name or password in use."); }

        //}






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