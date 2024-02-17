using Microsoft.EntityFrameworkCore;

namespace EAHS.Seeds
{
    public abstract class BaseSeeder
    {
        protected readonly ModelBuilder _modelBuilder;
        public BaseSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
    }
}
