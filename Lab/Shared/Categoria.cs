using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Categoria
    {
        public string nombre { get; set; }

        public IDictionary<int, Producto> listaProductos { get;set }
       
    }
}
