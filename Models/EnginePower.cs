using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class EnginePower
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Power { get; set; }
    }
}
