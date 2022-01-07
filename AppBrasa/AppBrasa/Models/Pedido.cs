using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;

        public decimal ValorTotal { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public int? ClienteId { get; set; }

        [ForeignKey("PagamentoId")]
        public Pagamento Pagamento { get; set; }
        public int? PagamentoId { get; set; }
    }
}
