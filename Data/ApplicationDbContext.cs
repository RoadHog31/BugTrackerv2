using BugTrackerv2.Data.Configurations;
using BugTrackerv2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerv2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //The DbContext also provide data querying capability via the DbSet property.
        public DbSet<Bug> BugForms { get; set; }


        //The DbContext is responsible for opening and managing connections to the database.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=app.db");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new BugConfiguration()).Seed();
            base.OnModelCreating(modelBuilder);

        }
    }
}
