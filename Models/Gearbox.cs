using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Gearbox
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string GearboxType { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
