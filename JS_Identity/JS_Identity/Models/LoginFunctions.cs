using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace JS_Identity.Models
{
    public class LoginFunctions
    {

        public static bool CreateAccount(string _name, string _password)
        {
            //var context = new AppUserContext();
            //var userStore = new UserStore<AppUser>(context);
            //var userManager = new UserManager<AppUser>(userStore);

            var context = new AppUserContext();
            var userStore = new UserStore<AppUser>(context);
            var userManager = new UserManager<AppUser>(userStore);





            var searchData = context.Users.Where(x => x.Name == _name).SingleOrDefault();

            if (searchData == null)
            {

                userManager.Create(user: new AppUser()
                {
                    Name = _name
                }, password: _password);

                return true;
            }
            else
            {
                return false;
            }
        }


    }
}