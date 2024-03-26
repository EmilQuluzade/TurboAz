using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StatusType { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
