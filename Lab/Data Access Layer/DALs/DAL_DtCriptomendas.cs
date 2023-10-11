using Data_Access_Layer.IDALS;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.DALs
{
    public class DAL_DtCriptomendas : IDAL_Criptomendas
    {
        DBContextCore _dbContext;

        public DAL_DtCriptomendas(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string direccionWallet)
        {
            var cripto = _dbContext.Criptomonedas.FirstOrDefault(cripto => cripto.DireccionWallet == direccionWallet);

            if (cripto != null)
            {
                _dbContext.Criptomonedas.Remove(cripto);
                _dbContext.SaveChanges();
            }
        }

        public List<DtCriptomoneda> Get()
        {
            return _dbContext.Criptomonedas.Select(cripto => new DtCriptomoneda
            {
                direccionWallet = cripto.DireccionWallet
            })
            .ToList();
        }

        public DtCriptomoneda get(string direccionWallet)
        {
            var c = _dbContext.Criptomonedas.FirstOrDefault(cripto => cripto.DireccionWallet == direccionWallet);

            if(c != null)
            {
                return new DtCriptomoneda
                {
                    direccionWallet = c.DireccionWallet
                };
            }
            return null;
        }

        public void Insert(DtCriptomoneda cripto)
        {
            var Cripto = new Data_Access_Layer.EF_Models.DtCriptomendas
            {
                DireccionWallet = cripto.direccionWallet
            };

            _dbContext.Criptomonedas.Add(Cripto);
            _dbContext.SaveChanges();
        }

        public void Update(DtCriptomoneda cripto)
        {
            var Cripto = _dbContext.Criptomonedas.FirstOrDefault(c => c.DireccionWallet ==  cripto.direccionWallet);

            if(Cripto != null)
            {
                Cripto.DireccionWallet = cripto.direccionWallet;

                _dbContext.Entry(Cripto).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }
    }
}
