namespace LetsHungry.API.DTOs
{
    public class OrderWithRezervationsDto:OrderDto
    {
        public RezervationDto Rezervations { get; set; }
    }
}
