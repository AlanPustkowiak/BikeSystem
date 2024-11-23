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
            var bike = bikes.FirstOrDefault(x => x.Id == id);
            if (bike != null)
            {
                bikes.Remove(bike);
                return Task.FromResult(true);
            }
            throw new Exception("Bike not found");
        }
    }
}
