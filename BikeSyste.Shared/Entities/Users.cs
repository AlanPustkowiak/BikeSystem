using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSyste.Shared.Entities
{
    public class Users
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public bool IsLogged { get; set; }
    }
}
