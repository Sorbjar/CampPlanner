using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampPlanner.Models
{
    public class Participant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
