using CodigoPenalApi.Data;
using CodigoPenalApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoPenalApi.Services.Implementations
{
    public class UserServiceImplementation : IUserService
    {
        private ApiContext _dbContext;

        public UserServiceImplementation(ApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Create(User user)
        {
            try
            {
                var result = _dbContext.Add(user);
                _dbContext.SaveChanges();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var UserExist = _dbContext.Users.Find(id);
            if (UserExist.Equals(true))
            {
                _dbContext.Remove(UserExist);
                _dbContext.SaveChanges();
            }

        }

        public List<User> FindAll()
        {
            try
            {
             return _dbContext.Users.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User FindById(int id)
        {
            try
            {
                return _dbContext.Users.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User Update(int id, string UserName, string Password)
        {
            var UserExist = _dbContext.Users.Find(id);
            if (UserExist.Equals(true))
            {

                UserExist.UserName = UserName;
                UserExist.Password = Password;

                _dbContext.SaveChanges();
                return UserExist;
            }
            else
            {
                return null;
            }
        }
    }
}
