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
    public class DAL_DtDirecciones : IDAL_DtDirecciones
    {
        DBContextCore _dbContext;

        public DAL_DtDirecciones(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string direccion)
        {
            var dir = _dbContext.Direcciones.FirstOrDefault(d => d.Direccion == direccion);

            if(dir != null)
            {
                _dbContext.Direcciones.Remove(dir);

                _dbContext.SaveChanges();
            }
        }

        public List<DtDirecciones> Get()
        {
            return _dbContext.Direcciones.Select(dir => new DtDirecciones
            {
                direccion1 = dir.Direccion,
                direccion2 = dir.Direccion2,
                nroPuerta = dir.NroPuerta
            })
            .ToList();
        }

        public DtDirecciones Get(string direccion)
        {
            var dir = _dbContext.Direcciones.FirstOrDefault(dir => dir.Direccion == direccion);

            if(dir != null)
            {
                return new DtDirecciones
                {
                    direccion1 = dir.Direccion,
                    direccion2 = dir.Direccion2,
                    nroPuerta = dir.NroPuerta
                };
            }

            return null;
        }

        public void Insert(DtDirecciones direccion)
        {
            var dir = new Data_Access_Layer.EF_Models.DtDirecciones
            {
                Direccion = direccion.direccion1,
                Direccion2 = direccion.direccion2,
                NroPuerta = direccion.nroPuerta
            };

            _dbContext.Direcciones.Add(dir);

            _dbContext.SaveChanges();
        }

        public void Update(DtDirecciones direccion)
        {
            var dir = _dbContext.Direcciones.FirstOrDefault(dir => dir.Direccion == direccion.direccion1);

            if(dir != null)
            {
                dir.Direccion = direccion.direccion1;
                dir.Direccion2 = direccion.direccion2;
                dir.NroPuerta = direccion.nroPuerta;

                _dbContext.Entry(dir).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }
    }
}
