using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class DtDirecciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(100), MinLength(4), Required]
        public string Direccion { get; set; } = "";

        [MaxLength(100), MinLength(4)]
        public string Direccion2 { get; set; } = "";

        [MaxLength(100), MinLength(4), Required]
        public int NroPuerta { get; set; }

        [Required]
        public long SucursalId { get; set; }

        [Required]
        public Sucursales Sucursal { get; set; }
    }
}
