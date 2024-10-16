namespace BikeSystem.Entities
{
    public class Bike
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public float Price { get; set; }
        
    }
}
