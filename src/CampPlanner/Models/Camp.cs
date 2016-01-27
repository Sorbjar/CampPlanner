using System;
using System.Collections.Generic;

namespace CampPlanner.Models
{
    public class Camp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<CampPlannerUser> Users { get; private set; }

        public Camp()
        {
            this.Users = new List<CampPlannerUser>();
        }
    }
}
