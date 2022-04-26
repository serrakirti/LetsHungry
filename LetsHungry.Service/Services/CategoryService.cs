using LetsHungry.Core.IntRepository;
using LetsHungry.Core.IntService;
using LetsHungry.Core.IntUnitOfWork;
using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unit, IRepository<Category> repo) : base(unit, repo)
        {
        }

        public async Task<Category> GetWithRestaurantByIdAsync(int catId)
        {
            return await _unit.Category.GetWithRestaurantByIdAsync(catId);
        }
    }
}
