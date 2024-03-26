using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Ownership
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string OwnerCount { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
