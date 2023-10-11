using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_Productos
    {
        List<Producto> Get();

        Producto Get(string codigo);

        void Insert(Producto producto);

        void Update(Producto producto);

        void Delete(string codigo);
    }
}
