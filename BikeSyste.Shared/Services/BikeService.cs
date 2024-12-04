using BikeSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Services
{
    public class BikeService : IBikeService
    {
        private static List<Bike> bikes;
        public BikeService()
        {
            if (bikes == null)
            {
                bikes = Bike.GetDefaultBikes();
            }
        }

        public Task<List<Bike>> GetAllBikes()
        {
            return Task.FromResult(bikes);
        }

        public Task<bool> DeleteBike(int id)
        {
            var dbBike = bikes.FirstOrDefault(x => x.Id == id);
            if (dbBike != null)
            {
                bikes.Remove(dbBike);
                return Task.FromResult(true);
            }
            throw new Exception("Bike not found");
        }

        public Task<Bike> GetBikeById(int id)
        {
            var dbBike = bikes.FirstOrDefault(x => x.Id == id);
            if (dbBike != null)
            {
                return Task.FromResult(dbBike);
            }
            throw new Exception("Bike not found");
        }

        public Task<Bike> UpdateBike(int id, Bike bike)
        {
            var dbBike = bikes.FirstOrDefault(x => x.Id == id);
            if (dbBike != null)
            {
                dbBike.Name = bike.Name;
                dbBike.Description = bike.Description;
                dbBike.Price = bike.Price;
                dbBike.Type = bike.Type;
                return Task.FromResult(bike);
            }
            throw new Exception("Bike not found");
        }

        public Task<Bike> AddBike(Bike bike)
        {
            bike.Id = bikes.Max(x => x.Id) + 1;
            bikes.Add(bike);
            return Task.FromResult(bike);
        }
    }
}
