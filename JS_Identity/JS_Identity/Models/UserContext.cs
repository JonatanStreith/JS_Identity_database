using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;


namespace JS_Identity.Models
{
    public class UserContext : IdentityDbContext<User>
    {

        public UserContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static UserContext Create()
        {
            return new UserContext();
        }



    }
}


