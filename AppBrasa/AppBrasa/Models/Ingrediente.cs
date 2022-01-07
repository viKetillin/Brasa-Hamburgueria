using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
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
