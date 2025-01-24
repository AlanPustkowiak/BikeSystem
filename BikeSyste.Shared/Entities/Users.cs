using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BikeSystem.Shared.Entities
{
    public class Users
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public bool IsLogged { get; set; }

        public static List<Users> GetDefaultUsers()
        {
            return new List<Users>
            {
                new Users
                {
                    Email = "admin@admin.pl",
                    Password = "admin",
                    Role = "Admin",
                    IsLogged = false
                },
                new Users
                {
                    Email = "user@user.pl",
                    Password = "user",
                    Role = "User",
                    IsLogged = false
                },
                new Users
                {
                    Email = "owner@owner.pl",
                    Password = "owner",
                    Role = "Owner",
                    IsLogged = false
                }
            };
        }
    }
}
