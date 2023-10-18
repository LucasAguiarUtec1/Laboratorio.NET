using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Categoria
    {
        public string Nombre { get; set; } = "";

        public required IDictionary<int, Producto> listaProductos1 { get; set; }

    }
}
