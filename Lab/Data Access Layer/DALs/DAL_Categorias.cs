using Data_Access_Layer.IDALS;
using DataAccessLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.DALs
{
    public class DAL_Categorias : IDAL_Categorias
    {
        private DBContextCore _dbContext;

        public DAL_Categorias(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string Nombre)
        {
            var p = _dbContext.Categorias.FirstOrDefault(p => p.nombre == Nombre);

            if (p != null)
            {
                _dbContext.Productos.Remove(p);
                _dbContext.SaveChanges();
            }
        }

        public List<Categoria> get()
        {
            //return _dbContext.Categorias.Select(p => new Categoria
            //{
                //Nombre = p.nombre,
                //listaProductos1 = p.listaProductos1,
            //})
            //.ToList();
            throw new NotImplementedException();
        }

        public Categoria Get(string Nombre)
        {
            throw new NotImplementedException();
        }

        public void Insert(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
