﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Carrito
    {
        public int id { get; set; }
        public IDictionary<int, Producto> listaProductos { get; set }
    }
}
