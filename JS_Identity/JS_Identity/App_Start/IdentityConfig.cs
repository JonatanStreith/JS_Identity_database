using JS_Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS_Identity.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var _context = new AppUserContext();
            var _rolestore = new RoleStore<AppUserRole>(_context);
            var _rolemanager = new RoleManager<AppUserRole>(_rolestore);

            app.CreatePerOwinContext(AppUserContext.Create);

            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);

            app.CreatePerOwinContext<RoleManager<AppUserRole>>((options, context) => _rolemanager);

            //app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
            });
        }
    }
}