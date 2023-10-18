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
    public class DAL_Productos : IDAL_Productos
    {
        private DBContextCore _dbContext;

        public DAL_Productos(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string codigo)
        {
            var p = _dbContext.Productos.FirstOrDefault(p => p.Codigo == codigo);
            
            if(p != null)
            {
                _dbContext.Productos.Remove(p);
                _dbContext.SaveChanges();
            }
        }

        public List<Producto> Get()
        { 
            return _dbContext.Productos.Select(p => new Producto
            {
                Codigo = p.Codigo,
                Descripcion = p.Descripcion,
                Imagen = p.Imagen,
                Titulo = p.Titulo
            })
            .ToList();
        }

        public Producto Get(string codigo)
        {
            var p = _dbContext.Productos.FirstOrDefault(p => p.Codigo == codigo);

            if(p != null)
            {
                return new Producto
                {
                    Codigo = p.Codigo,
                    Titulo = p.Titulo,
                    Descripcion = p.Descripcion,
                    Imagen = p.Imagen,
                };
            }
            return new Producto();
        }

        public void Insert(Producto producto)
        {
            var p = new Data_Access_Layer.EF_Models.Productos
            {
                Codigo = producto.Codigo,
                Descripcion= producto.Descripcion,
                Imagen = producto.Imagen,
                Titulo = producto.Titulo
            };

            _dbContext.Productos.Add(p);
            _dbContext.SaveChanges();
        }

        public void Update(Producto producto)
        {
            var p = _dbContext.Productos.FirstOrDefault(p => p.Codigo == producto.Codigo);

            if(p != null)
            {
                p.Titulo = producto.Titulo;
                p.Descripcion = producto.Descripcion;
                p.Imagen = producto.Imagen;
                
                _dbContext.Entry(p).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }
    }
}
