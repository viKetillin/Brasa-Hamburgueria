using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("ProdutoFranquia")]
    public class ProdutoFranquia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 100)]
        public double Valor { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }


        [ForeignKey("FranquiaId")]
        public Franquia Franquia { get; set; }

        public int FranquiaId { get; set; }
    }
}
