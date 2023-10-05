using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
    public class DtTarjeta : DtMetodoDePago
    {
        // Atributos

        public string NumeroTarjeta { get; set; }
        public string Titular { get; set; }
        public string FechaExpiracion { get; set; }
        public string Cvv { get; set; }

    }
}
