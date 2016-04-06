using System.ComponentModel.DataAnnotations;

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
