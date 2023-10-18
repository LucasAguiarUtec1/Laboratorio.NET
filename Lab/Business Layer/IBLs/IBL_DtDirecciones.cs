using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.IBLs
{
    public interface IBL_DtDirecciones
    {
        List<DtDirecciones> Get();

        DtDirecciones Get(string direccion);

        void Insert(DtDirecciones direccion);

        void Update(DtDirecciones direccion);

        void Delete(string direccion);
    }
}
