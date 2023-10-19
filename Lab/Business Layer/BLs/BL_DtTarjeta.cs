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
    public class BL_DtTarjeta : IBL_DtTarjeta
    {
        private IDAL_DtTarjeta _DtTarjeta;

        public void Delete(string numeroTarjeta)
        {
            _DtTarjeta.Delete(numeroTarjeta);
        }

        public List<DtTarjeta> Get()
        {
            return _DtTarjeta.Get();
        }

        public DtTarjeta Get(string numeroTarjeta)
        {
            return _DtTarjeta.Get(numeroTarjeta);
        }

        public void Insert(DtTarjeta tarjeta)
        {
            _DtTarjeta.Insert(tarjeta);
        }

        public void Update(DtTarjeta tarjeta)
        {
            _DtTarjeta.Update(tarjeta);
        }
    }
}
