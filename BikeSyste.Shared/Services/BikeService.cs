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
        public BikeService()
        {
        }

        public Task<List<Bike>> GenerateBike()
        {
            List<Bike> bikes = new List<Bike>();
            Bike bike = new()
            {
                Id = 1,
                Name = "Rowex 2000",
                Description = "Dobry rower górski",
                Price = 20,
                Type = "górski"
            };
            bikes.Add(bike);
            return Task.FromResult(bikes);
        }
    }
}
