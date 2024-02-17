using EAHS.Models;
using EAHS.Seeds;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace EAHS.Repositories
{
    public class EAHSDbContext : DbContext
    {
        public EAHSDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Judges> Judges { get; set; }
        public DbSet<Rules> Rules { get; set; }
        public DbSet<Country> Country { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            modelBuilder.Seed();
        }
    }
}