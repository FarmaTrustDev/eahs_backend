using Microsoft.EntityFrameworkCore;

namespace EAHS.Seeds
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            new CountriesSeeder(modelBuilder);
            new UserSeeder(modelBuilder);
            new RulesSeeder(modelBuilder);
            new JudgesSeeder(modelBuilder);
            //new QPSTatusSeeder(modelBuilder);
        }
    }
}
