using Core.Reposetories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Service
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public User GetUser(string Email, string password)
        {
            return _userRepository.GetUser(Email, password);
        }
    }
}
