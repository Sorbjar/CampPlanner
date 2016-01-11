using CampPlanner.Model;
using CampPlanner.Models.Database.Generic;
using Microsoft.Data.Entity;

namespace CampPlanner.Models.Database.Context
{
    public class CampPlannerContext : GenericDBContext
    {

        public CampPlannerContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Camp> Camps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = Startup.Configuration["Data:CampPlannerContextConnection"];

            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
