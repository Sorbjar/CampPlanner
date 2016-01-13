using CampPlanner.Models;
using CampPlanner.Models.Database.Context;
using CampPlanner.Models.Database.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampPlanner.Models.Database.Repository
{
    public class CampRepository : GenericRepository<CampPlannerContext, Camp>
    {

    }
}
