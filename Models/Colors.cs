using System.ComponentModel.DataAnnotations;

namespace Turbo.az.Models
{
    public class Colors
    {
        [Key]
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
