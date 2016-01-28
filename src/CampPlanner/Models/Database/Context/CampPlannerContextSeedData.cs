using Microsoft.AspNet.Identity;
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
        }
    }
}
