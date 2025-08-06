using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Core.Services
{
    public interface IUserService
    {
        public User GetUser(string Email, string password);
        public User AddUser(User user);
    }
}
