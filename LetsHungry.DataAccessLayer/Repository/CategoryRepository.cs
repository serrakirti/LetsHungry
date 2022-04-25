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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(LetsHungryDbContext db) : base(db)
        {

        }
        public async Task<Category> GetWithRestaurantByIdAsync(int catId)
        {
            return (await _db.Categories.Include(s => s.Restaurants).FirstOrDefaultAsync(s => s.Id == catId))!;
        }
    }
}
