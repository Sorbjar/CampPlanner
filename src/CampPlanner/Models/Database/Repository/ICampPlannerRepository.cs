using System.Collections.Generic;
using System.Security.Principal;

namespace CampPlanner.Models.Database.Repository
{
    public interface ICampPlannerRepository
    {
        //TODO summary
        IEnumerable<Camp> GetAllCamps(CampPlannerUser user);
        //TODO summary
        Camp GetCamp(int id);
    }
}
