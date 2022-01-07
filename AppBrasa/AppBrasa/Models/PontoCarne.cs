using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppBrasa.Models
{
    [Table("PontoCarne")]
    public class PontoCarne
    {
        [Key]
        public int Id { get; set; }

        public string NomePontoCarne { get; set; }
    }
}
