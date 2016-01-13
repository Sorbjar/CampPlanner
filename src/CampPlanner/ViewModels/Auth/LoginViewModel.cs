using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampPlanner.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Username { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Password { get; set; }
    }
}
