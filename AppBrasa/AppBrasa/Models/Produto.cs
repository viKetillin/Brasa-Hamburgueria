using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        #nullable enable
        [StringLength(200)]
        public string? ImagemProduto { get; set; }
        #nullable disable

        [Required]
        [StringLength(200)]
        public string NomeProduto { get; set; }

        #nullable enable
        [StringLength(500)]
        public string? DescricaoProduto { get; set; }

        [StringLength(500)]
        public string? ProductDescription { get; set; }
        #nullable disable

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public ICollection<ProdutoIngrediente> ProdutoIngredientes { get; set; }
    }
}
