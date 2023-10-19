using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class Productos
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(100), MinLength(4), Required]
        public string Codigo { get; set; } = "";

        [MaxLength(128), MinLength(3), Required]
        public string Titulo { get; set; } = "";

        [MaxLength(128), MinLength(3), Required]
        public string Descripcion { get; set; } = "";

        [Required]
        public required byte[] Imagen { get; set; }

        public long CarritoId { get; set; }
        [Required]
        public virtual Carritos Carrito { get; set; }
        
        public virtual ICollection<CategoriaProductos> Categorias { get; set; }

        public long EmpresaId {  get; set; }
        public virtual Empresas Empresa { get; set; } = null!;
    }
}
