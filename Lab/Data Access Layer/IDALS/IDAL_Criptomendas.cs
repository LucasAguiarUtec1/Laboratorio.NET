using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_Criptomendas
    {
        List<DtCriptomoneda> Get();

        DtCriptomoneda get(string direccionWallet);

        void Insert(DtCriptomoneda cripto);

        void Update(DtCriptomoneda cripto);

        void Delete(string direccionWallet);
    }
}
