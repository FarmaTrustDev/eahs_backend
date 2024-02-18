using EAHS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EAHS.Seeds
{
    public class JudgesSeeder:BaseSeeder
    {
        public JudgesSeeder(ModelBuilder modelBuilder) : base(modelBuilder)
        {
            Up();
        }

        private void Up()
        {
            _modelBuilder.Entity<Judges>().HasData(LoadData());
        }

        private static List<Judges> LoadData()
        {
            List<Judges> Judges = new List<Judges>();

            Judges.Add(new Judges()
            {
                Id = 1,
                JudgeName = "WILLIAM OPPEN",
                CountryName = "Argentina",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 2,
                JudgeName = "ALLAN PRESTON",
                CountryName = "Australia",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 3,
                JudgeName = "ELISABETH CHAT ",
                CountryName = "Austria",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 4,
                JudgeName = "ELYAS EBRAHIM FARAJ",
                CountryName = "Bahrain",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 5,
                JudgeName = "HELEN HENNEKENS",
                CountryName = "Belgium",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 6,
                JudgeName = "MARTINE VAN HEE",
                CountryName = "Belgium ",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 7,
                JudgeName = "MURILLO KAMER",
                CountryName = "Brazil",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 8,
                JudgeName = "MARIANNE TENGSTEDT",
                CountryName = "Denmark",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 9,
                JudgeName = "ABDEL RAOUF ABBAS",
                CountryName = "Egypt",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 10,
                JudgeName = "ALI SHAARAWI",
                CountryName = "Egypt",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 11,
                JudgeName = "KLAUS BESTE",
                CountryName = "Germany",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 12,
                JudgeName = "SYLVIE EBERHARDT",
                CountryName = "Germany",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 13,
                JudgeName = "JONAS SALZMANN",
                CountryName = "Kuwait",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 14,
                JudgeName = "KARIN ZEEVENHOVEN",
                CountryName = "Netherlands",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 15,
                JudgeName = "ANNA STOJANOWSKA",
                CountryName = "Poland",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 16,
                JudgeName = "LUCAS GOZDZIALSKI",
                CountryName = "Poland",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 17,
                JudgeName = "IRINA STIGLER",
                CountryName = "Russia",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 18,
                JudgeName = "DEIRDRE HYDE",
                CountryName = "UK",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 19,
                JudgeName = "JERZY GEROGES ZBYSZEWSKI",
                CountryName = "USA",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 20,
                JudgeName = "GREG KNOWLES",
                CountryName = "USA",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 21,
                JudgeName = "JACQUELINE VANDYKE",
                CountryName = "UK",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 22,
                JudgeName = "LAURA MASCAGNA",
                CountryName = "Italy",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 23,
                JudgeName = "MOHAMMED HAMMAD",
                CountryName = "Egypt",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 24,
                JudgeName = "SALEM ALKATHEERI",
                CountryName = "UAE",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 25,
                JudgeName = "HAMED ALHARTHI",
                CountryName = "UAE",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 26,
                JudgeName = "LIZETTE SVENSSON",
                CountryName = "Sweden",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            Judges.Add(new Judges()
            {
                Id = 27,
                JudgeName = "PETER HEGEMANN",
                CountryName = "Germany",
                IsConflict = false,
                IsMember = false,
                Active = true,
                CreatedAt = System.DateTime.Now
            });
            return Judges;
        }
    }
}

