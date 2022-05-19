namespace LetsHungry.Web.DTOs
{
    public class RezervationWithOrdersDto
    {
        public ICollection<OrderDto> Orders { get; set; }
    }
}
