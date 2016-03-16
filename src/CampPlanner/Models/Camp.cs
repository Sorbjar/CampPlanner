using System;

namespace CampPlanner.Models
{
    public class Camp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //TODO manage users, managers, admins, ... (other roles)
        public CampPlannerUser Owner { get; set; }

        public Camp()
        {
        }

        //TODO summary
        //TODO Correct user handling
        internal bool CanAccess(CampPlannerUser user)
        {
            if (Owner.Id == user.Id)
                return true;
            return false;
        }
    }
}
