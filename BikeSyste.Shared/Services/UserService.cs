using BikeSyste.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSyste.Shared.Services
{
    public class UserService : IUserService
    {
        public Task<List<Users>> GenerateUser()
        {
            List<Users> users = new List<Users>();
            Users user0 = new()
            {
                Email = "test@test.pl",
                Password = "test",
                Role = "admin"
            }; 
            Users user1 = new()
            {
                Email = "user@user.pl",
                Password = "user",
                Role = "user"
            };
            users.Add(user0);
            users.Add(user1);
            return Task.FromResult(users);
        }
    }
}
