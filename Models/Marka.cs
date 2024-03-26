using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Turbo.az.Models
{
    public class Marka
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string MarkaName { get; set; }
        public virtual required List<Model> Model { get; set; }
    }
}
