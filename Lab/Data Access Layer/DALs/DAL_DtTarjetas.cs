using Data_Access_Layer.IDALS;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.DALs
{
    public class DAL_DtTarjetas : IDAL_DtTarjeta
    {
        private DBContextCore _dbContext;

        public DAL_DtTarjetas(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string numeroTarjeta)
        {
            var p = _dbContext.Tarjetas.FirstOrDefault(t => t.NumeroTarjeta == numeroTarjeta);

            if(p != null)
            {
                _dbContext.Tarjetas.Remove(p);
                _dbContext.SaveChanges();
            }
        }

        public List<DtTarjeta> Get()
        {
            return _dbContext.Tarjetas.Select(p => new DtTarjeta
            {
                Titular = p.Titular,
                Cvv = p.Cvv,
                FechaExpiracion = p.FechaExpiracion,
                NumeroTarjeta = p.NumeroTarjeta,
            })
            .ToList();
        }

        public DtTarjeta Get(string numeroTarjeta)
        {
            var t = _dbContext.Tarjetas.FirstOrDefault(t => t.NumeroTarjeta == numeroTarjeta);

            if(t != null)
            {
                return new DtTarjeta
                {
                    Titular = t.Titular,
                    Cvv = t.Cvv,
                    FechaExpiracion = t.FechaExpiracion,
                    NumeroTarjeta = t.NumeroTarjeta,
                };
            }
            
            return new DtTarjeta();
        }

        public void Insert(DtTarjeta tarjeta)
        {
            var p = new Data_Access_Layer.EF_Models.DtTarjetas
            {
                Titular = tarjeta.Titular,
                Cvv = tarjeta.Cvv,
                FechaExpiracion = tarjeta.FechaExpiracion,
                NumeroTarjeta = tarjeta.NumeroTarjeta,

            };

            _dbContext.Tarjetas.Add(p);
            _dbContext.SaveChanges();
        }

        public void Update(DtTarjeta tarjeta)
        {
            var t = _dbContext.Tarjetas.FirstOrDefault(t => t.NumeroTarjeta ==  tarjeta.NumeroTarjeta);

            if(t != null )
            {
                t.Titular = tarjeta.Titular;
                t.NumeroTarjeta = tarjeta.NumeroTarjeta;
                t.FechaExpiracion = tarjeta.FechaExpiracion;
                t.Cvv = tarjeta.Cvv;

                _dbContext.Entry(t).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }
    }
}
