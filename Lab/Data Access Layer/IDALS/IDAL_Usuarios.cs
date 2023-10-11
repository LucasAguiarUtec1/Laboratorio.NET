using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.IDALS
{
    public interface IDAL_Usuarios
    {
        List<Usuario> Get();

        Usuario Get(String mail);

        void Insert(Usuario usuario);

        void Update(Usuario usuario);

        void Delete(String mail);
    }
}
