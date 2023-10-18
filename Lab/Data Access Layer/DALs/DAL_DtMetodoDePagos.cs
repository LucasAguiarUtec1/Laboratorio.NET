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
    public class DAL_DtMetodoDePagos : IDAL_DtMetodoDePago
    {
        DBContextCore _dbContext;

        public DAL_DtMetodoDePagos(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string tipoPago)
        {
            var mP = _dbContext.MetodoDePagos.FirstOrDefault(mp => mp.MetodoDePago == tipoPago);

            if(mP != null)
            {
                _dbContext.MetodoDePagos.Remove(mP);
                _dbContext.SaveChanges();
            }
        }

        public List<DtMetodoDePago> Get()
        {
            return _dbContext.MetodoDePagos.Select(mp => new DtMetodoDePago
            {
                tipoMetodoPago = mp.MetodoDePago,
            })
            .ToList();
        }

        public DtMetodoDePago Get(string tipoPago)
        {
            var mP = _dbContext.MetodoDePagos.FirstOrDefault(mp => mp.MetodoDePago == tipoPago);

            if (mP != null)
            {
                return new DtMetodoDePago
                {
                    tipoMetodoPago = mP.MetodoDePago,
                };
            }
            return new DtMetodoDePago();
        }

        public void Insert(DtMetodoDePago metodoDePago)
        {
            var mP = new Data_Access_Layer.EF_Models.DtMetodoDePagos
            {
                MetodoDePago = metodoDePago.tipoMetodoPago,
            };

            _dbContext.MetodoDePagos.Add(mP);
            _dbContext.SaveChanges();

        }

        public void Update(DtMetodoDePago metodo)
        {
            var mP = _dbContext.MetodoDePagos.FirstOrDefault(mp => mp.MetodoDePago == metodo.tipoMetodoPago);

            if (mP != null)
            {
                mP.MetodoDePago = metodo.tipoMetodoPago;

                _dbContext.Entry(mP).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }
    }
}
