using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("DiaFuncionamento")]
    public class DiaFuncionamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DayOfWeek DiaSemana { get; set; }

        [Required]
        public bool Aberto { get; set; }

        [ForeignKey("FranquiaId")]
        public Franquia Franquia { get; set; }

        public int FranquiaId { get; set; }
    }
}
