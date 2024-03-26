using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Year
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Years { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
