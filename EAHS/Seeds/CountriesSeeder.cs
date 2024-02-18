using EAHS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EAHS.Seeds
{
    public class CountriesSeeder : ISeeder
    {
        private readonly ModelBuilder _modelBuilder;
        private readonly IHostEnvironment _hostingEnvironment;

        public CountriesSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            Up();
        }

        private void Up()
        {
            _modelBuilder.Entity<Country>().HasData(LoadJson());
        }

        private List<Country> LoadJson()
        {

            var templatePath = System.IO.Path.Combine((string)System.IO.Directory.GetCurrentDirectory(), "wwwroot\\Seeds\\Json\\countries.json");

            List<Country> DbCountries = new List<Country>();
            using (StreamReader r = new StreamReader(templatePath))
            {
                string json = r.ReadToEnd();
                List<CountryData> countries = JsonConvert.DeserializeObject<List<CountryData>>(json);
                foreach (var (country, index) in countries.Select((country, index) => (country, index)))
                {

                    DbCountries.Add(new Country { Id = index + 1, Name = country.name, ISO = country.code, CountryCode = country.dial_code, FlagPath = country.flagPath ,Active = true });
                }
            }

            return DbCountries;
        }




    }

    internal class Countires
    {
        public List<CountryData> CountryData { get; set; }
    }
    internal class CountryData
    {
        public string id { get; set; }

        public string code { get; set; }

        public string dial_code { get; set; }

        public string name { get; set; }
        public string flagPath { get; set; }
    }
}
