using Microsoft.AspNet.Identity;
using Microsoft.Data.Entity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CampPlanner.Models.Database.Context
{
    public class CampPlannerContextSeedData
    {
        private CampPlannerContext _context;
        private UserManager<CampPlannerUser> _userManager;

        public CampPlannerContextSeedData(CampPlannerContext context, UserManager<CampPlannerUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task EnsureSeedDataAsync()
        {
            if ((await _userManager.FindByEmailAsync("sam.hastings@camp.com")) == null)
            {
                //Add the user
                var newUSer = new CampPlannerUser()
                {
                    UserName = "samhastings",
                    Email = "sam.hastings@camp.com"
                };
                await _userManager.CreateAsync(newUSer, "Passw0rd!");
            }

            if (!_context.Camps.Any())
            {
                CampPlannerUser cu = await _userManager.FindByEmailAsync("sam.hastings@camp.com");
                Camp seedCamp = new Camp
                {
                    Name = "SeedCamp",
                    StartDate = DateTime.Now.AddDays(6),
                    EndDate = DateTime.Now.AddDays(20)
                };
                seedCamp.Owner = cu;
                _context.Camps.Add(seedCamp);



                _context.SaveChanges();
            }
        }
    }
}
