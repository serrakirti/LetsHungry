namespace LetsHungry.Web.DTOs
{
    public class ProductCategoryWithProductsDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
