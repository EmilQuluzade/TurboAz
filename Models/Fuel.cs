using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Fuel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FuelType { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
