using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_DtDirecciones
    {
        List<DtDirecciones> Get();

        DtDirecciones Get(string direccion);

        void Insert(DtDirecciones direccion);

        void Update(DtDirecciones direccion);

        void Delete(string direccion);
    }
}
