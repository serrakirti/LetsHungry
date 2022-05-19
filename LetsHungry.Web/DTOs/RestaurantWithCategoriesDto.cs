namespace LetsHungry.Web.DTOs
{
    public class RestaurantWithCategoriesDto:RestaurantDto
    {
        public CategoryDto Category { get; set; }
    }
}
