using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string NomeFormaPagamento { get; set; }

        public decimal Troco { get; set; }

        [Required]
        public bool Entrega { get; set; }
    }
}
