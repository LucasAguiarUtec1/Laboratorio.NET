using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class DtTarjetas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(20), MinLength(20), Required]
        public string NumeroTarjeta { get; set; } = "0000 0000 0000 0000";

        [MaxLength(128), MinLength(4), Required]
        public string Titular { get; set; } = "";

        [Required]
        public DateTime FechaExpiracion { get; set; }

        [MaxLength(6), MinLength(3), Required]
        public int Cvv { get; set; } = 000;
    }
}
