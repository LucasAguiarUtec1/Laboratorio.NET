﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
    public class Usuario
    {
        // Atributos
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string contrasenia { get; set; }
        public DtDirecciones[] direcciones { get; set; }
        public DtMetodoDePago[] metodoDePagos { get; set; }
    
    }
}
