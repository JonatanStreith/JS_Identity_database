using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS_Identity.Models
{
    public class StaticData
    {




        public static void AddData()                //Creates cities and countries and adds them to the context
        {
            List<Country> Countries = new List<Country>
            {
                new Country() {Name = "Sweden"},
                new Country() {Name = "USA"},
                new Country() {Name = "Equestria"},
                new Country() {Name = "Skyrim"},
                new Country() {Name = "New California Republic"}
            };

            List<City> Cities = new List<City>
            {
                new City() {Name = "Stockholm", CountryName = "Sweden"},
                new City() {Name = "Lindesberg", CountryName = "Sweden"},
                new City() {Name = "Skovde", CountryName = "Sweden"},
                new City() {Name = "New York", CountryName = "USA"},
                new City() {Name = "Phoenix", CountryName = "USA"},
                new City() {Name = "Denver", CountryName = "USA"},
                new City() {Name = "Ponyville", CountryName = "Equestria"},
                new City() {Name = "Canterlot", CountryName = "Equestria"},
                new City() {Name = "Manehattan", CountryName = "Equestria"},
                new City() {Name = "Whiterun", CountryName = "Skyrim"},
                new City() {Name = "Solitude", CountryName = "Skyrim"},
                new City() {Name = "Windhelm", CountryName = "Skyrim"},
                new City() {Name = "Shady Sands", CountryName = "New California Republic"},
                new City() {Name = "Primm", CountryName = "New California Republic"},
                new City() {Name = "Hopesville", CountryName = "New California Republic"}
            };

            foreach (City city in Cities)
            {
                foreach (Country country in Countries)
                {
                    if(country.Name == city.CountryName)    //Does this city reside in this country?
                    {
                        city.InCountry = country;
                        country.Cities.Add(city);
                    }
                }
            }

            using(var context = new WorldContext())
            {
                context.Cities.AddRange(Cities);
                context.Countries.AddRange(Countries);
            }



        }




    }
}