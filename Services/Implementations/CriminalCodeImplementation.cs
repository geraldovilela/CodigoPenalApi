using CodigoPenalApi.Controllers;
using CodigoPenalApi.Data;
using CodigoPenalApi.Models;
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

        public CriminalCode Delete(int id)
        {
            throw new NotImplementedException();
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
