using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turbo.az.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
        [Required]

        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual required Cars Cars { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
