using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("ProdutoPedido")]
    public class ProdutoPedido
    {
        [Key]
        public int Id { get; set; }

        public decimal? Valor { get; set; }

        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }
        public int? PedidoId { get; set; }

        [ForeignKey("PontoCarneId")]
        public PontoCarne PontoCarne { get; set; }
        public int? PontoCarneId { get; set; }

        [ForeignKey("ProdutoFranquiaId")]
        public ProdutoFranquia ProdutoFranquia { get; set; }
        public int? ProdutoFranquiaId { get; set; }
    }
}
