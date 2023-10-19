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
    public class BL_DtMetodoDePago : IBL_DtMetodoDePago
    {
        private IDAL_DtMetodoDePago _DtMetodoDePago;

        public void Delete(string tipoPago)
        {
            _DtMetodoDePago.Delete(tipoPago);
        }

        public List<DtMetodoDePago> Get()
        {
            return _DtMetodoDePago.Get();
        }

        public DtMetodoDePago Get(string tipoPago)
        {
            return _DtMetodoDePago.Get(tipoPago);
        }

        public void Insert(DtMetodoDePago metodoDePago)
        {
            _DtMetodoDePago.Insert(metodoDePago);
        }

        public void Update(DtMetodoDePago metodo)
        {
            _DtMetodoDePago.Update(metodo);
        }
    }
}
