using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Entities
{
    public class UserToAddDTO
    {
        public string? email { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
    }
}
