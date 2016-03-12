using CampPlanner.Models.Database.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var camps = _context.Camps
                    //c.Owner.Id == user.Id (because states can change)
                    .Where(c => c.Owner.Id == user.Id)
                    .OrderBy(t => t.Name)
                    .ToList();
                return camps.Where(c => c.Owner == user).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get camps from database", ex);
                return null;
            }
        }
    }
}
