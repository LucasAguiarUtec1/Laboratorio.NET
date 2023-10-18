using Business_Layer.IBLs;
using Data_Access_Layer.IDALS;
using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.BLs
{
    public class BL_Usuarios : IBL_Usuarios
    {
        private IDAL_Usuarios _Usuarios;

        public void Delete(string mail)
        {
            _Usuarios.Delete(mail);
        }

        public List<Usuario> Get()
        {
            return _Usuarios.Get();
        }

        public Usuario Get(string mail)
        {
            return _Usuarios.Get(mail);
        }

        public void Insert(Usuario usuario)
        {
            _Usuarios.Insert(usuario);
        }

        public void Update(Usuario usuario)
        {
            _Usuarios.Update(usuario);
        }
    }
}
