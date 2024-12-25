using BikeSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Services
{
    public class BikeRepairService : IBikeRepairService
    {
        private static List<BikeRepair> bikeRepairs;
        public BikeRepairService()
        {
            if (bikeRepairs == null)
            {
                bikeRepairs = BikeRepair.GetDefaultBikeRepairs();
            }
        }
        public Task<List<BikeRepair>> GetAllBikeRepairs()
        {
            return Task.FromResult(bikeRepairs);
        }
        public Task<bool> DeleteBikeRepair(int id)
        {
            var dbBikeRepair = bikeRepairs.FirstOrDefault(x => x.Id == id);
            if (dbBikeRepair != null)
            {
                bikeRepairs.Remove(dbBikeRepair);
                return Task.FromResult(true);
            }
            throw new Exception("BikeRepair not found");
        }
        public Task<BikeRepair> GetBikeRepairById(int id)
        {
            var dbBikeRepair = bikeRepairs.FirstOrDefault(x => x.Id == id);
            if (dbBikeRepair != null)
            {
                return Task.FromResult(dbBikeRepair);
            }
            throw new Exception("BikeRepair not found");
        }
        public Task<BikeRepair> UpdateBikeRepair(int id, BikeRepair bikeRepair)
        {
            var dbBikeRepair = bikeRepairs.FirstOrDefault(x => x.Id == id);
            if (dbBikeRepair != null)
            {
                dbBikeRepair.BikeId = bikeRepair.BikeId;
                dbBikeRepair.Description = bikeRepair.Description;
                dbBikeRepair.Date = bikeRepair.Date;
                dbBikeRepair.Price = bikeRepair.Price;
                dbBikeRepair.Status = bikeRepair.Status;
                return Task.FromResult(bikeRepair);
            }
            throw new Exception("BikeRepair not found");

        }
    }
}
