using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Carrito
    {
        public required IDictionary<int, Producto> ListaProductos { get; set; }
    }
}
