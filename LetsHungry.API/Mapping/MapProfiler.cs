using AutoMapper;
using LetsHungry.API.DTOs;
using LetsHungry.Core.Models;

namespace LetsHungry.API.Mapping
{
    public class MapProfiler : Profile
    {
        public MapProfiler()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Restaurant, RestaurantDto>();
            CreateMap<RestaurantDto, Restaurant>();

            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();

            CreateMap<ProductCategory, ProductCategoryDto>();
            CreateMap<ProductCategoryDto, ProductCategory>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Raiting, RaitingDto>();
            CreateMap<RaitingDto, Raiting>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<Rezervation, RezervationDto>();
            CreateMap<RezervationDto, Rezervation>();

            CreateMap<Category, CategoryWithRestaurantsDto>();
            CreateMap<CategoryWithRestaurantsDto, Category>();

            CreateMap<Restaurant, RestaurantWithCategoriesDto>();
            CreateMap<RestaurantWithCategoriesDto, Restaurant>();

            CreateMap<Rezervation, RezervationWithOrdersDto>();
            CreateMap<RezervationWithOrdersDto, Rezervation>();

            CreateMap<Order, OrderWithRezervationsDto>();
            CreateMap<OrderWithRezervationsDto, Order>();

            CreateMap<ProductCategory, ProductCategoryWithProductsDto>();
            CreateMap<ProductCategoryWithProductsDto, ProductCategory>();

            CreateMap<Product, ProductWithProductCategoriesDto>();
            CreateMap<ProductWithProductCategoriesDto, Product>();

            CreateMap<User, UserWithCommentsDto>();
            CreateMap<UserWithCommentsDto, User>();

            CreateMap<Comment, CommentWithUsersDto>();
            CreateMap<CommentWithUsersDto, Comment>();

       
        }
    }
}
