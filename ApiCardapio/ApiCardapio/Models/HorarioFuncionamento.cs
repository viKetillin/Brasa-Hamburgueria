using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("HorarioFuncionamento")]
    public class HorarioFuncionamento
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime? HoraInicio { get; set; }

        [DataType(DataType.Time)]
        public DateTime? HoraFim { get; set; }

        [ForeignKey("DiaFuncionamentoId")]
        public DiaFuncionamento DiaFuncionamento { get; set; }
        public int DiaFuncionamentoId { get; set; }
    }
}
