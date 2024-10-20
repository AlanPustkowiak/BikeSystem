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
        List<Users> users = new List<Users>();
        public Task<List<Users>> GenerateUser()
        {
            Users user0 = new()
            {
                Email = "test@test.pl",
                Password = "test",
                Role = "admin",
                IsLogged = false
            }; 
            Users user1 = new()
            {
                Email = "user@user.pl",
                Password = "user",
                Role = "user",
                IsLogged = false
            };
            users.Add(user0);
            users.Add(user1);
            return Task.FromResult(users);
        }

        public Task<bool> IsLogged()
        {
            bool result = false;
            foreach (Users user in users)
            {
                if (user.IsLogged) { result = true; }
            }
            return Task.FromResult(result);
        }
    }
}
