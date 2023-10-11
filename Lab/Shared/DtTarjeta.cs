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

        public string NumeroTarjeta { get; set; } = "";
        public string Titular { get; set; } = "";   
        public DateTime FechaExpiracion { get; set; }
        public int Cvv { get; set; } = 000;

    }
}
