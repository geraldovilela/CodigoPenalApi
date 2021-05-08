using CodigoPenalApi.Models;
using CodigoPenalApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodigoPenalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriminalCodeController : ControllerBase
    {
        private ICriminalCodeService _CriminalCodeService;
        public CriminalCodeController(ICriminalCodeService criminalCodeService)
        {
            _CriminalCodeService = criminalCodeService;
        }
        [HttpPost]
        public Task<CriminalCode> Create([FromBody] CriminalCode criminalCode)
        {
            _CriminalCodeService.Create(criminalCode);

            return null;
        }
    }
}
