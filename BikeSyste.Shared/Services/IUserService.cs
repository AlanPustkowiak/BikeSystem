using BikeSyste.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSyste.Shared.Services
{
    public interface IUserService
    {
        Task<List<Users>> GenerateUser();
    }
}
