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
        Task<Users?> IsLogged();
        Task<bool> CheckUser(string email, string password);
        Task<List<Users>?> GetAllUsers();
        Task<bool> DeleteUser(string email);
        Task<UserToAddDTO> AddUser(UserToAddDTO userToAddDTO);
        Task<UserToAddDTO> GetUserByEmail(string email);
        Task<UserToAddDTO> UpdateUser(UserToAddDTO userToAddDTO);
        Task<List<double?>> GetUsersByRoleCount();
        Task<List<string>> GetActiveRoleNames();
    }
}
