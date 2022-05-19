using LetsHungry.Web.DTOs;
using Newtonsoft.Json;
using System.Text;


namespace LetsHungry.Web.ApiServices
{
    public class RestaurantApiService
    {
        private readonly HttpClient _httpClient;

        public RestaurantApiService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }

        public async Task<IEnumerable<RestaurantWithCategoriesDto>> GetAllAsync()
        {
            IEnumerable<RestaurantWithCategoriesDto> resDtos;
            var response = await _httpClient.GetAsync("restaurant");
            if (response.IsSuccessStatusCode)
            {
               resDtos =JsonConvert.DeserializeObject<IEnumerable<RestaurantWithCategoriesDto>>(await response.Content.ReadAsStringAsync())!;

            }
            else
            {
                resDtos = null!;
            }
            return resDtos;
        }


        public async Task<RestaurantWithCategoriesDto> AddAsync(RestaurantWithCategoriesDto resDtos)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(resDtos), Encoding.UTF8, "application/json");//tek bir satır gönderiyoruz

            var response = await _httpClient.PostAsync("restaurant", stringContent);
            if (response.IsSuccessStatusCode)
            {
                resDtos = JsonConvert.DeserializeObject<RestaurantWithCategoriesDto>(await response.Content.ReadAsStringAsync())!;
                return resDtos;
            }
            else
            {
                return null!;
            }
        }


        public async Task<bool> Update(RestaurantWithCategoriesDto resDtos)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(resDtos), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"restaurant", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<RestaurantWithCategoriesDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"restaurant/{id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<RestaurantWithCategoriesDto>(await response.Content.ReadAsStringAsync())!;
            }
            else
            {
                return null!;
            }
        }
        //public async Task<IEnumerable<RestaurantWithCategoriesDto>> GetAllWithCategoryAsync()
        //{
        //    IEnumerable<RestaurantWithCategoriesDto> restaurantDtos;
        //    var response = await _httpClient.GetAsync("Restaurant/categoryall");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        restaurantDtos =
        //            JsonConvert.DeserializeObject<IEnumerable<RestaurantWithCategoriesDto>>(await response.Content.ReadAsStringAsync())!; 
        //    }
        //    else
        //    {
        //        restaurantDtos = null!;
        //    }
        //    return restaurantDtos;
        //}
       

    }
}
