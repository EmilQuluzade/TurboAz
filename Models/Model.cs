using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turbo.az.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public virtual required List<Cars> Cars { get; set; }
        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }
        public int MarkaId { get; set; }

        [ForeignKey("MarkaId")]
        public virtual required Marka Marka { get; set; }
    }
}
