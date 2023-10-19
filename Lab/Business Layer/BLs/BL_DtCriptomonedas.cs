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
    public class BL_DtCriptomonedas : IBL_DtCriptomonedas
    {
        private IDAL_DtCriptomonedas _DtCriptomonedas;

        public void Delete(string direccionWallet)
        {
            _DtCriptomonedas.Delete(direccionWallet);
        }

        public List<DtCriptomonedas> Get()
        {
            return _DtCriptomonedas.Get();
        }

        public DtCriptomonedas get(string direccionWallet)
        {
            return _DtCriptomonedas.get(direccionWallet);
        }

        public void Insert(DtCriptomonedas cripto)
        {
            _DtCriptomonedas.Insert(cripto);
        }

        public void Update(DtCriptomonedas cripto)
        {
            _DtCriptomonedas.Update(cripto);
        }
    }
    }
}
