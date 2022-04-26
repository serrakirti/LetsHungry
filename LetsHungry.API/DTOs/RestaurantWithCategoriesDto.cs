namespace LetsHungry.API.DTOs
{
    public class RestaurantWithCategoriesDto:RestaurantDto
    {
        public CategoryDto Category { get; set; }
    }
}
