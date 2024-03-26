using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
