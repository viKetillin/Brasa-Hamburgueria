using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string DescricaoCategoria { get; set; }

        #nullable enable
        [StringLength(100)]
        public string? CategoryDescription { get; set; }
        #nullable disable
    }
}
