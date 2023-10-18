using shared;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_Carritos
    {
        List<Carrito> get();

        Carrito Get(int id);

        void Insert(Carrito carrito);

        void Update(Carrito carrito);

        void Delete(int id);
    }
}
