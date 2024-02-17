using EAHS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EAHS.Seeds
{
    public class UserSeeder : BaseSeeder
    {
        public UserSeeder(ModelBuilder modelBuilder) : base(modelBuilder)
        {
            Up();
        }

        private void Up()
        {
            _modelBuilder.Entity<User>().HasData(LoadData());
        }

        private static List<User> LoadData()
        {
            List<User> users = new List<User>();

            users.Add(new User()
            {
                Id = 1,
                UserName = "eahs",
                Password = "sf/WPJ/YEvZZrFchRMF92A==", // test123
                Email = "eahs@hotmail.com",
                Active = true
            });
            return users;
        }
    }
}
