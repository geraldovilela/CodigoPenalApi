using CodigoPenalApi.Models;
using CodigoPenalApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodigoPenalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Rota para criação do user
        /// </summary>
        /// <param name="value">Parametros: UserName = String, Password = String</param>
        /// <returns User="User"></returns>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User value)
        {
            var result = _userService.Create(value);
            if (result != null)
            { return Ok(result); } 
            else
            {
                return BadRequest();
            }
            
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<User> Get()
        {
            return _userService.FindAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.FindById(id);
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public User Put(int id, [FromBody] string UserName, string Password)
        {
            return _userService.Update(id, UserName, Password);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}
