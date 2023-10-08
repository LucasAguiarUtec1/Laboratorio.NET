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
        public int id {  get; set; }
        public string numeroTarjeta { get; set; }
        public string titular { get; set; }
        public string fechaExpiracion { get; set; }
        public string cvv { get; set; }

    }
}
