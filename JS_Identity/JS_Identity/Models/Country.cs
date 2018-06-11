using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS_Identity.Models
{
    public class Country
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<City> Cities { get; set; }
    }
}