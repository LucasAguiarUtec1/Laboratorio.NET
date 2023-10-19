using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_DtCriptomonedas
    {
        List<DtCriptomonedas> Get();

        DtCriptomonedas get(string direccionWallet);

        void Insert(DtCriptomonedas cripto);

        void Update(DtCriptomonedas cripto);

        void Delete(string direccionWallet);
    }
}
