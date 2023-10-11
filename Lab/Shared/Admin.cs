using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Admin : Usuario
    {
        public Empresa empresaAsociada { get; set; }
    }
}
