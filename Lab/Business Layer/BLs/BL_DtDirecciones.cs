using Business_Layer.IBLs;
using Data_Access_Layer.IDALS;
using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.BLs
{
    public class BL_DtDirecciones : IBL_DtDirecciones
    {
        private IDAL_DtDirecciones _DtDirecciones;

        public void Delete(string direccion)
        {
            _DtDirecciones.Delete(direccion);
        }

        public List<DtDirecciones> Get()
        {
            return _DtDirecciones.Get();
        }

        public DtDirecciones Get(string direccion)
        {
           return _DtDirecciones.Get(direccion);
        }

        public void Insert(DtDirecciones direccion)
        {
            _DtDirecciones.Insert(direccion);
        }

        public void Update(DtDirecciones direccion)
        {
            _DtDirecciones.Update(direccion);
        }
    }
}
