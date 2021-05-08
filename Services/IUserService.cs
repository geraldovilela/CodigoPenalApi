using CodigoPenalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodigoPenalApi.Services
{
    public interface IUserService
    {
        public User Create(User user);
        
        public User FindById(int id);
        
        public List<User> FindAll();
        
        public User Update(int id, string UserName, string Password);

        public void Delete(int id);
    }
}
