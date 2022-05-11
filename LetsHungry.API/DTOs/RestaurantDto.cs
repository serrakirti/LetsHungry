namespace LetsHungry.API.DTOs
{
    public class RestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
      
    }
}
