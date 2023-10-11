using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_DtTarjeta
    {
        List<DtTarjeta> Get();

        DtTarjeta Get(string numeroTarjeta);

        void Insert(DtTarjeta tarjeta);

        void Update(DtTarjeta tarjeta);

        void Delete(string numeroTarjeta);

    }
}
