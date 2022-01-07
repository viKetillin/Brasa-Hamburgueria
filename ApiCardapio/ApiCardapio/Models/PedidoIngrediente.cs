using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("PedidoIngrediente")]
    public class PedidoIngrediente
    {
        [Key]
        public int Id { get; set; }

        public double Quantidade { get; set; }

        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }

        [ForeignKey("IngredienteId")]
        public Ingrediente Ingrediente { get; set; }
        public int? IngredienteId { get; set; }

        [ForeignKey("ProdutoPedidoId")]
        public ProdutoPedido ProdutoPedido { get; set; }
        public int ProdutoPedidoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int? ProdutoId { get; set; }
    }
}
