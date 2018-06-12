using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JS_Identity.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string Name { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
    }
}