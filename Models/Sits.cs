using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Sits
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SitCount { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
