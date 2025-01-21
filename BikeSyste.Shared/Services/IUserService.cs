﻿using BikeSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Services
{
    public interface IUserService
    {
        Task<bool> IsLogged();
        Task<bool> CheckUser(string email, string password);
        Task<List<Users>?> GetAllUsers();
        Task<bool> DeleteUser(string email);
        Task<UserToAddDTO> AddUser(UserToAddDTO userToAddDTO);
    }
}
