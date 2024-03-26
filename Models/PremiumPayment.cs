using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class PremiumPayment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PremiumId { get; set; }

        [ForeignKey("PremiumId")]
        public virtual Premium Premium { get; set; }
        public int CarId { get; set; }
        
        [ForeignKey("CarId")]
        public virtual Cars Cars { get; set; }

        public PremiumPayment() => isPayed = false; // Set default value to false
        public bool isPayed { get; set; }
        public DateTime DateTime { get; set; }
    }
}
