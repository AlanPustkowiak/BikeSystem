using BikeSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Services
{
    public interface IBikeRepairService
    {
        Task<List<BikeRepair>> GetAllBikeRepairs();
        Task<bool> DeleteBikeRepair(int id);
        Task<BikeRepair> GetBikeRepairById(int id);
        Task<BikeRepair> UpdateBikeRepair(int id, BikeRepair bikeRepair);
        Task<List<double?>> GetRepairCountByStatus();
        Task<BikeRepair> AddBikeRepair(Bike bikeRepair);
    }
}
