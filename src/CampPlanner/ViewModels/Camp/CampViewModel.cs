using System;
using System.ComponentModel.DataAnnotations;

namespace CampPlanner.ViewModels.Camp
{
    public class CampViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Name { get; set; }
        //TODO validate EndDate after or equal to StartDate
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
