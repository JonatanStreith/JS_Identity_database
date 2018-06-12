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
            var context = new UserContext();
            var userStore = new UserStore<User>(context);
            var userManager = new UserManager<User>(userStore);

           // context.Users.Contains()

            userManager.Create(user: new User()
            {
                Name = _name
            }, password: _password);


            return true;
        }
    

    }
}