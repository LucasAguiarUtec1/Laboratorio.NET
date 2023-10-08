using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }

        IDictionary<int, Producto> listaProductos { get;set }
    }
}
