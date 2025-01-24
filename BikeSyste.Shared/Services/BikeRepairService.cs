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
        private IBikeService _bikeService;
        public BikeRepairService(IBikeService bikeService)
        {
            if (bikeRepairs == null)
            {
                bikeRepairs = BikeRepair.GetDefaultBikeRepairs();
            }

            _bikeService = bikeService;
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

        public Task<List<double?>> GetRepairCountByStatus()
        {
            var repairCountByStatus = bikeRepairs.GroupBy(x => x.Status).Select(x => (double?)x.Count()).ToList();
            return Task.FromResult(repairCountByStatus);
        }

        public Task<BikeRepair> AddBikeRepair(Bike bikeRepair)
        {
            BikeRepair bikeRepair1 = new BikeRepair();
            bikeRepair1.Id = GetMaxId() + 1;
            bikeRepair1.BikeId = _bikeService.GetMaxId();
            bikeRepair1.Description = bikeRepair.Description;
            bikeRepair1.Date = DateTime.Now;
            bikeRepair1.Price = 0;
            bikeRepair1.Status = "Oczekuje";
            bikeRepairs.Add(bikeRepair1);
            return Task.FromResult(bikeRepair1);
        }

        public int GetMaxId()
        {
            return bikeRepairs.Max(x => x.Id);
        }
    }
}
