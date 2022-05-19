namespace LetsHungry.Web.DTOs
{
    public class CategoryWithRestaurantsDto:CategoryDto
    {
        public ICollection<RestaurantDto> Restaurants { get; set; }
    }
}
