using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Turbo.az.Models
{
    public class Premium
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Time { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual required List<PremiumPayment> PremiumPayment { get; set; }
    }
}
