using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Empresa
    {
        public string Direcciones { get; set; } = "";

        public required IDictionary<int, Categoria> ListaCategoria1 { get; set; }

        public required IDictionary<int, Producto> ListaProducto1{get; set;}
         
        public required IDictionary<int, Sucursal> ListaSucursal1{get; set;}
         
        public required IDictionary<int, OrdenCompra> ListaOrdenCompra1{get; set;}

    }
}
