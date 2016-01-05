using CampPlanner.Model;
using Microsoft.Data.Entity;

namespace CampPlanner.Models.Database.Context
{
    public class CampContext : DbContext
    {
        public CampContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Camp> Camps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = Startup.Configuration["Data:CampContextConnection"];

            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
