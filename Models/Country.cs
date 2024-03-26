using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string CountryName { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
