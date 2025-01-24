using BikeSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Services
{
    public interface IBikeService
    {
        Task<List<Bike>> GetAllBikes();
        Task<bool> DeleteBike(int id);
        Task<Bike> GetBikeById(int id);
        Task<Bike> UpdateBike(int id,Bike bike);
        Task<Bike> AddBike(Bike bike);
        int GetMaxId();
    }
}
