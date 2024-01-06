using Microsoft.EntityFrameworkCore;
using Repo.Models.Data;

namespace AJAX_Application.Models.Data
{
    public class AppDbConext : DbContext
    {
        public AppDbConext(DbContextOptions<AppDbConext> options)
        : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(c => c.Cities)
                .WithOne(c => c.Country)
                .HasForeignKey(c => c.CountryId);
        }
    }
}
