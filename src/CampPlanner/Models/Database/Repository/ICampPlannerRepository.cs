using System.Collections.Generic;
using System.Security.Principal;

namespace CampPlanner.Models.Database.Repository
{
    public interface ICampPlannerRepository
    {
        IEnumerable<Camp> GetAllCamps(CampPlannerUser user);
    }
}
