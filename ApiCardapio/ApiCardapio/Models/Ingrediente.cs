using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("Ingrediente")]
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeIngrediente { get; set; }

        #nullable enable
        [StringLength(100)]
        public string? NameIngredient { get; set; }
        #nullable disable

        [Required]
        [Range(1, 100)]
        public double Valor { get; set; }
    }
}
