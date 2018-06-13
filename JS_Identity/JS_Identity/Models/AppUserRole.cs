using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS_Identity.Models
{
    public class AppUserRole : IdentityRole
    {
        public AppUserRole() : base() { }
        public AppUserRole(string name) : base(name) { }

    }
}