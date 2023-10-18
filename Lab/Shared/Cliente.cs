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
        public required Dictionary<string, DtDirecciones> Direcciones { get; set; }
        public required Dictionary<string, DtMetodoDePago> MetodoDePagos { get; set; }
        public required List<Calificacion> Calificaciones { get; set; }
        public required Carrito? Carrito { get; set; }
        public required IDictionary<int, OrdenCompra> ListaOrdenCompra1 { get; set; }

    }
}
