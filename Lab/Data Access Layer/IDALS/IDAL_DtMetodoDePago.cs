using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_DtMetodoDePago
    {
        List<DtMetodoDePago> Get();

        DtMetodoDePago Get(string tipoPago);

        void Insert(DtMetodoDePago metodoDePago);

        void Update(DtMetodoDePago metodo);

        void Delete(string tipoPago);
    }
}
