using LetsHungry.Core.IntRepository;
using LetsHungry.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer.Repository
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(LetsHungryDbContext db) : base(db)
        {
        }

        public async Task<ProductCategory> GetWithProductByIdAsync(int procatId)
        {
            return (await _db.ProductCategories.Include(s => s.Products).FirstOrDefaultAsync(s => s.Id == procatId))!;
        }
    }
}
