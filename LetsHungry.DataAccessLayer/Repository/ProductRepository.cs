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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(LetsHungryDbContext db) : base(db)
        {
        }

        public async Task<Product> GetWithProductCategoryByIdAsync(int proId)
        {
            return (await _db.Products.Include(s => s.ProductCategories).FirstOrDefaultAsync(s => s.Id == proId))!;
        }
    }
}
