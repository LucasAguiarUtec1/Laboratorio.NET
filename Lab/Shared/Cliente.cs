using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Cliente : Usuario
    {
        public int id { get; set; }
        public Dictionary<string, DtDirecciones> direcciones { get; set; }
        public Dictionary<string, DtMetodoDePago> metodoDePagos { get; set; }
        public List<Calificacion> calificaciones { get; set; }
        public Carrito carrito { get; set; }
        public IDictionary<int, OrdenCompra> listaOrdenCompra { get; set}
    }
}
