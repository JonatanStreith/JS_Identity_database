using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS_Identity.Models
{
    public class City
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string CountryName { get; set; }
        public Country InCountry { get; set; }
    }
}