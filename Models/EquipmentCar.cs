using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turbo.az.Models
{
    public class EquipmentCar
    {
        [Key]
        public int Id { get; set; }
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual required Cars Cars { get; set; }
        public int EquipmentId { get; set; }
        [ForeignKey("EquipmentId")]
        public virtual required Equipment Equipment { get; set; }
    }
}
