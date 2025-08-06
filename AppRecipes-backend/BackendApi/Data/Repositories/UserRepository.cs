using Core.Reposetories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetUser(string Email, string password)
        {
          var user=_context.Users.FirstOrDefault(x=>x.Email.Equals(Email) && x.Password.Equals(password));
            return user;
        }
    }
}
