using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Producto
    {
        public Producto()
        {
            Imagen = new byte[0];
        }

        public string Codigo { get; set; } = "";
        public string Titulo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public byte[] Imagen { get; set; }

    }
}
