using CodigoPenalApi.Controllers;
using CodigoPenalApi.Data;
using CodigoPenalApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoPenalApi.Services.Implementations
{
    public class CriminalCodeImplementation : ICriminalCodeService
    {
        private ApiContext _dbContext;

        public CriminalCodeImplementation(ApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CriminalCode Create(CriminalCode criminalCode)
        {
            try
            {
                var result = _dbContext.Entry<CriminalCode>(criminalCode);
                _dbContext.SaveChanges();
                return criminalCode;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var result = _dbContext.CriminalCodes.Find(id);
                if (result != null)
                {
                    _dbContext.Remove(result);
                    _dbContext.SaveChanges();
                    return null;
                }
                return null;                 
               
            }
            catch (Exception)
            {

                throw;
            };
            
        }

        public List<CriminalCode> FindAll()
        {
            throw new NotImplementedException();
        }

        public CriminalCode FindById(int id)
        {
            throw new NotImplementedException();
        }

        public CriminalCode Update(CriminalCode code)
        {
            throw new NotImplementedException();
        }
    }
}
