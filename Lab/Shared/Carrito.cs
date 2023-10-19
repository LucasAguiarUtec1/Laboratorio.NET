using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Carrito
    {
        public long Id { get; set; }
        public required ICollection<Producto> ListaProductos { get; set; }
    }
}
