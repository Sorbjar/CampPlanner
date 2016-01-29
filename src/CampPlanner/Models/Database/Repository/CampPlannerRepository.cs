using CampPlanner.Models.Database.Context;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace CampPlanner.Models.Database.Repository
{
    public class CampPlannerRepository : ICampPlannerRepository
    {
        private CampPlannerContext _context;
        private ILogger<CampPlannerRepository> _logger;

        public CampPlannerRepository(CampPlannerContext context, ILogger<CampPlannerRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Camp> GetAllCamps(CampPlannerUser user)
        {
            try
            {
                _logger.LogInformation("Getting camps for user {userName} from database");
                //TODO include where clause in select
                var camps = _context.Camps
                    .Include(c => c.Users)
                    //.Where(c => c.Users.Contains(user))
                    .OrderBy(t => t.Name)
                    .ToList();
                return camps.Where(c => c.Users.Contains(user)).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get camps from database", ex);
                return null;
            }
        }
    }
}
