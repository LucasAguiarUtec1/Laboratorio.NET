using shared;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_Categorias
    {
        List<Categoria> get();

        Categoria Get(string Nombre);

        void Insert(Categoria categoria);

        void Update(Categoria categoria);

        void Delete(string Nombre);
    }
}
