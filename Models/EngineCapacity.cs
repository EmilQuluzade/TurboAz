using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class EngineCapacity
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public int Capacity { get; set;}
        public virtual required List<Cars> Cars { get; set; }
    }
}
