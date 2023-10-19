using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class Sucursales
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(124), MinLength(5), Required]
        public string Ubicacion { get; set; }

        [MaxLength(124), MinLength(5), Required]
        public DtDirecciones Direccion { get; set; }

        public long EmpresaId { get; set; }
        public virtual Empresas Empresa { get; set; } = null!;

    }
}
