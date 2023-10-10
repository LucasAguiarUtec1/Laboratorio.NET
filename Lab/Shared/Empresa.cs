using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    internal class Empresa
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public IDictionary<int,Categoria> listaCategoria { get;set}
        public IDictionary<int, Producto> listaProducto { get; set}
        public IDictionary<int, Sucursal> listaSucursal { get; set}
        public IDictionary<int, OrdenCompra> listaOrdenCompra { get; set}
    }
}
