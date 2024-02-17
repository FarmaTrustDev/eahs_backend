using EAHS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EAHS.Seeds
{
    public class RulesSeeder : BaseSeeder
    {
        public RulesSeeder(ModelBuilder modelBuilder) : base(modelBuilder)
        {
            Up();
        }

        private void Up()
        {
            _modelBuilder.Entity<Rules>().HasData(LoadData());
        }

        private static List<Rules> LoadData()
        {
            List<Rules> rules = new List<Rules>();

            rules.Add(new Rules()
            {
                Id = 1,
                RuleName = "Apply one Judge per country rule",
                Active = true,
                IsIncluded = false,
            });
            rules.Add(new Rules()
            {
                Id = 2,
                RuleName = "Apply Conflict of interest rule",
                Active = true,
                IsIncluded = false,
            });
            rules.Add(new Rules()
            {
                Id = 3,
                RuleName = "Apply EAHS member rule",
                Active = true,
                IsIncluded = false,
            });
            return rules;
        }
    }
}
