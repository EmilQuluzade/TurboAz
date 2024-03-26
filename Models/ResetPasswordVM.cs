using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class ResetPasswordVM
    {
        public string Token { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passworlar eyni deyil")]
        public string ConfirmPassword { get; set; }
    }
}
