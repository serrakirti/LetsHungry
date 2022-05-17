namespace LetsHungry.API.DTOs
{
    public class ProductCategoryWithProductsDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
