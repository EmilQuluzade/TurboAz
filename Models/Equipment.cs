using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string EquipmentName { get; set; }
    }
}
