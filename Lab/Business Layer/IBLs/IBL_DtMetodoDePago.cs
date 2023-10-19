using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.IBLs
{
    public interface IBL_DtMetodoDePago
    {
        List<DtMetodoDePago> Get();

        DtMetodoDePago Get(string tipoPago);

        void Insert(DtMetodoDePago metodoDePago);

        void Update(DtMetodoDePago metodo);

        void Delete(string tipoPago);
    }
}
