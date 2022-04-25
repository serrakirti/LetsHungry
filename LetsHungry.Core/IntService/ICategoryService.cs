using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.IntService
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithRestaurantByIdAsync(int catId);
    }
}
