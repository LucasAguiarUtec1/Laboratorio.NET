using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class Categorias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(50), MinLength(125), Required]
        public string nombre { get; set; }
       
        public virtual ICollection<CategoriaProductos> Productos { get; set; }

        public long EmpresaId { get; set; }
        public virtual Empresas Empresa { get; set; } = null!;
    }
}
