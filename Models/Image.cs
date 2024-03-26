using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turbo.az.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual required Cars Cars { get; set; }
        [Required]
        public bool is_primary { get; set; }
        [Required]
        [StringLength(255)]
        public string ImgUrl { get; set; }
    }
}
