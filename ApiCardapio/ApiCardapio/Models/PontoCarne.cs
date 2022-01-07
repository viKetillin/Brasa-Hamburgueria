using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCardapio.Models
{
    [Table("PontoCarne")]
    public class PontoCarne
    {
        [Key]
        public int Id { get; set; }

        public string NomePontoCarne { get; set; }
    }
}
