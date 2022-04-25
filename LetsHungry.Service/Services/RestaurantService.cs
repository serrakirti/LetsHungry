using LetsHungry.Core.IntRepository;
using LetsHungry.Core.IntService;
using LetsHungry.Core.IntUnitOfWork;
using LetsHungry.Core.Models;

namespace LetsHungry.Service.Services
{
    public class RestaurantService : Service<Restaurant>, IRestaurantService
    {
        public RestaurantService(IUnitOfWork unit, IRepository<Restaurant> repo) : base(unit, repo)
        {
        }

        public async Task<Restaurant> GetWithCategoryByIdAsync(int resId)
        {
            return await _unit.Restaurant.GetWithCategoryByIdAsync(resId);
        }
    }
}
