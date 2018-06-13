using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;


namespace JS_Identity.Models
{
    public class AppUserContext : IdentityDbContext<AppUser>
    {

        public AppUserContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static AppUserContext Create()
        {
            return new AppUserContext();
        }



    }
}


