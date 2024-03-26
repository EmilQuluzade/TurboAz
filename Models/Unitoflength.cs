using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Unitoflength
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Unit { get; set; }

        public virtual required List<Cars> Cars { get; set; }
    }
}
