using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class Empresas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(124), MinLength(5), Required]
        public string Nombre { get; set; }
        
        public virtual ICollection<Productos> Productos { get; set; }
        
        public virtual ICollection<Sucursales> Sucursales { get; set; }

        public virtual ICollection<Categorias> Categorias { get; set; }
    }
}
