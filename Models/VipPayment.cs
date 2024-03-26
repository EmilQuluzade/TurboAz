using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turbo.az.Models
{
    public class VipPayment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VipId { get; set; }

        [ForeignKey("VipId")]
        public virtual Vip Vip { get; set; }
        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public virtual Cars Cars { get; set; }

        public VipPayment() => isPayed = false; // Set default value to false
        public bool isPayed { get; set; }
        public DateTime DateTime { get; set; }
    }
}
