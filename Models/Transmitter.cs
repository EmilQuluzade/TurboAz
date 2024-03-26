using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Transmitter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TransmitterType { get; set; }
        public virtual required List<Cars> Cars { get; set; }
    }
}
