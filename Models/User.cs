using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class User : IdentityUser
    {
       [Required]
        public bool IsSalon { get; set; }
        public string? BackgroundImage { get; set; }
        public bool isBanned { get; set; }

        public User() => isBanned = false;
    }
}
