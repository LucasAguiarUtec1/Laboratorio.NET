using Data_Access_Layer.EF_Models;
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
    public class DAL_Carritos : IDAL_Carritos
    {
        private DBContextCore _dbContext;

        public DAL_Carritos(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int id)
        {
            var p = _dbContext.Carritos.FirstOrDefault(p => p.Id == id);

            if (p != null)
            {
                _dbContext.Carritos.Remove(p);
                _dbContext.SaveChanges();
            }
        }

        public List<Carrito> get()
        {
            return _dbContext.Carritos.Select(p => new Carrito
            {
                Id = p.Id,
                ListaProductos = (ICollection<Producto>)p.ProductosEnCarrito,
            })
            .ToList();
        }

        public Carrito Get(int id)
        {
            var p = _dbContext.Carritos.FirstOrDefault(p => p.Id == id);

            if (p != null)
            {
                return new Carrito
                {
                    Id = p.Id,
                    ListaProductos = (ICollection<Producto>)p.ProductosEnCarrito,
                };
            }
            return new Carrito
            { ListaProductos = null };
        }

        public void Insert(Carrito carrito)
        {
            var p = new Data_Access_Layer.EF_Models.Carritos
            {
                Id = carrito.Id,
                ProductosEnCarrito = (ICollection<Productos>)carrito.ListaProductos,
            };

            _dbContext.Carritos.Add(p);
            _dbContext.SaveChanges();
        }

        public void Update(Carrito carrito)
        {
            var p = _dbContext.Carritos.FirstOrDefault(p => p.Id == carrito.Id);

            if (p != null)
            {
                p.Id = carrito.Id;
                p.ProductosEnCarrito = (ICollection<Productos>)carrito.ListaProductos;

                _dbContext.Entry(p).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }
    }
}
