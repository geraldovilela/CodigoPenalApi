using CodigoPenalApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoPenalApi.Services
{
    public interface ICriminalCodeService
    {
        public CriminalCode Create(CriminalCode criminalCode);

        public CriminalCode Update(CriminalCode code);

        public CriminalCode FindById(int id);

        public List<CriminalCode> FindAll();

        public IActionResult Delete(int id);
    }
}


