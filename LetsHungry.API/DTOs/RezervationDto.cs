namespace LetsHungry.API.DTOs
{
    public class RezervationDto
    {
        public int Id { get; set; }
        public DateTime? RezervationDate { get; set; }
        public int Guest { get; set; }
        public int RestaurantId { get; set; }
        public int OrderId { get; set; }
    }
}
