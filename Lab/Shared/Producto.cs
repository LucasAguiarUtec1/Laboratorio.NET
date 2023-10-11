using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Producto
    {

        public string titulo { get; set; }
        public string descripcion { get; set; }
        public byte[] imagen { get; set; }
        public float precio { get; set; }
        public int tipoIva {get; set; }
        public byte[] archivoPdf { get; set; }
        public IDictionary<int, Categoria> listaCategorias { get;set}
        public IDictionary<int, Categoria> listaCategoriasRelacionadas { get; set}
        public List<Calificacion> calificaciones { get; set; }


    }
}
