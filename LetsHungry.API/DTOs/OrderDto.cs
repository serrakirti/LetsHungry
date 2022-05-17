namespace LetsHungry.API.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal FinalPrice { get; set; }
        public int UserId { get; set; }
    }
}
