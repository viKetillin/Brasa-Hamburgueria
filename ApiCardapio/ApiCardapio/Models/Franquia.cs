using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("Franquia")]
    public class Franquia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        [Required]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }

        [Required]
        public string Logo { get; set; }
    }
}
