using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
    public class DtCriptomoneda : DtMetodoDePago
    {
        // Atributos
        public int id { get; set; }
        public string direccionWallet { get; set; }
    }
}
