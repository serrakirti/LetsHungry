namespace LetsHungry.API.DTOs
{
    public class RezervationWithOrdersDto
    {
        public ICollection<OrderDto> Orders { get; set; }
    }
}
