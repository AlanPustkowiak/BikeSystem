using BikeSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Services
{
    public class UserService : IUserService
    {
        private static List<Users>? users;

        public UserService()
        {
            if (users == null)
            {
                users = Users.GetDefaultUsers();
            }
        }

        public Task<UserToAddDTO> AddUser(UserToAddDTO userToAddDTO)
        {
            var user = users.FirstOrDefault(x => x.Email == userToAddDTO.email);
            if (user != null)
            {
                throw new DuplicateNameException("User already exists");
            }
            else
            {
                var newUser = new Users
                {
                    Email = userToAddDTO.email,
                    Password = userToAddDTO.password,
                    Role = userToAddDTO.role
                };
                users.Add(newUser);
                return Task.FromResult(userToAddDTO);
            }
        }

        public Task<bool> CheckUser(string email, string password)
        {
            var account = users.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (account != null)
            {
                account.IsLogged = true;
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        public Task<bool> DeleteUser(string email)
        {
            var user = users.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                users.Remove(user);
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        public Task<List<Users>?> GetAllUsers()
        {
            return Task.FromResult(users);
        }

        public Task<bool> IsLogged()
        {
            bool result = users.Any(x => x.IsLogged == true);
            return Task.FromResult(result);
        }

    }
}
