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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
