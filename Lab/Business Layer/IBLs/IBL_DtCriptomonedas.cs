using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.IBLs
{
    public interface IBL_DtCriptomonedas
    {
        List<DtCriptomonedas> Get();

        DtCriptomonedas get(string direccionWallet);

        void Insert(DtCriptomonedas cripto);

        void Update(DtCriptomonedas cripto);

        void Delete(string direccionWallet);
    }
}
