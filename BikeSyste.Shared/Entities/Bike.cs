namespace BikeSystem.Shared.Entities
{
    public class Bike
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public float Price { get; set; }

        public static List<Bike> GetDefaultBikes()
        {
            return new List<Bike>
            {
                new Bike
                {
                    Id = 1,
                    Name = "Rowex 2000",
                    Description = "Dobry rower górski",
                    Price = 20,
                    Type = "górski"
                },
                new Bike
                {
                    Id = 2,
                    Name = "Rowex 3000",
                    Description = "Dobry rower miejski",
                    Price = 15,
                    Type = "miejski"
                },
                new Bike
                {
                    Id = 3,
                    Name = "Rowex 4000",
                    Description = "Dobry rower szosowy",
                    Price = 25,
                    Type = "szosowy"
                }
            };
        }

    }
}
