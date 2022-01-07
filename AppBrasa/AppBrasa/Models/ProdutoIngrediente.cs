using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("ProdutoIngrediente")]
    public class ProdutoIngrediente
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IngredienteId")]
        public Ingrediente Ingrediente { get; set; }
        public int IngredienteId { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }

        public double? Quantidade { get; set; }
    }
}
