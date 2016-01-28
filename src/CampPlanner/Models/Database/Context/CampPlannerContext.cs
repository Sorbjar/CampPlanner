using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace CampPlanner.Models.Database.Context
{
    public class CampPlannerContext : IdentityDbContext<CampPlannerUser>
    {

        public CampPlannerContext()
        {
           // Database.EnsureCreated();
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
