using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSystem.Shared.Entities
{
    public class BikeRepair
    {
        public int Id { get; set; }
        public int BikeId { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public DateOnly? EndDate { get; set; }

        public static List<BikeRepair> GetDefaultBikeRepairs()
        {
            return new List<BikeRepair>
            {
                new BikeRepair
                {
                    Id = 1,
                    BikeId = 1,
                    Description = "Naprawa roweru",
                    Date = DateTime.Now,
                    Price = 20,
                    Status = "W trakcie",
                    EndDate = new DateOnly(2025, 10, 10)
                },
                new BikeRepair
                {
                    Id = 2,
                    BikeId = 2,
                    Description = "Naprawa roweru",
                    Date = DateTime.Now,
                    Price = 15,
                    Status = "W trakcie",
                    EndDate = new DateOnly(2025, 05, 18)
                },
                new BikeRepair
                {
                    Id = 3,
                    BikeId = 3,
                    Description = "Naprawa roweru",
                    Date = DateTime.Now,
                    Price = 25,
                    Status = "Zakończono",
                    EndDate = new DateOnly(2025, 02, 10)
                }
            };
        }

    }
}
