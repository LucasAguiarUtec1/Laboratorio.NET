using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.IBLs
{
    public interface IBL_Usuarios
    {
        List<Usuario> Get();

        Usuario Get(String mail);

        void Insert(Usuario usuario);

        void Update(Usuario usuario);

        void Delete(String mail);
    }
}
