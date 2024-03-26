using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Vip
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Time { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual required List<VipPayment> VipPayment { get; set; }
    }
}
