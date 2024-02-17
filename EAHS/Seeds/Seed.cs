using Microsoft.EntityFrameworkCore;

namespace EAHS.Seeds
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            new UserSeeder(modelBuilder);
            new RulesSeeder(modelBuilder);
            //new QPSTatusSeeder(modelBuilder);
        }
    }
}
