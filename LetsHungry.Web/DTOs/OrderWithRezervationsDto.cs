namespace LetsHungry.Web.DTOs
{
    public class OrderWithRezervationsDto:OrderDto
    {
        public RezervationDto Rezervations { get; set; }
    }
}
