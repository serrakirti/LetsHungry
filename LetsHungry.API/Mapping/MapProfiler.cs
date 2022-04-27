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

            CreateMap<Category, CategoryWithRestaurantsDto>();
            CreateMap<CategoryWithRestaurantsDto, Category>();

            CreateMap<Restaurant, RestaurantWithCategoriesDto>();
            CreateMap<RestaurantWithCategoriesDto, Restaurant>();

            CreateMap<User, UserWithCommentsDto>();
            CreateMap<UserWithCommentsDto, User>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
