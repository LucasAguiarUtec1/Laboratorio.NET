using Business_Layer.IBLs;
using Data_Access_Layer.IDALS;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.BLs
{
    public class BL_Productos : IBL_Productos
    {
        private IDAL_Productos _Productos;

        public void Delete(string codigo)
        {
            _Productos.Delete(codigo);
        }

        public List<Producto> Get()
        {
           return _Productos.Get();
        }

        public Producto Get(string codigo)
        {
            return _Productos.Get(codigo);
        }

        public void Insert(Producto producto)
        {
            _Productos.Insert(producto);
        }

        public void Update(Producto producto)
        {
            _Productos.Update(producto);
        }
    }
}
