using LetsHungry.Core.IntRepository;
using LetsHungry.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer.Repository
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(LetsHungryDbContext db):base(db)
        {

        }
        public async Task<Restaurant> GetWithCategoryByIdAsync(int resId)
        {
            var restaurant = _db.Restaurants.Include(s => s.Category).FirstOrDefaultAsync(s => s.Id == resId);
            return (await restaurant)!;
        }
    }
}
