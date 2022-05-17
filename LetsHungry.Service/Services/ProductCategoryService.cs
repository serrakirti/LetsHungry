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
    public class ProductCategoryService : Service<ProductCategory>, IProductCategoryService
    {
        public ProductCategoryService(IUnitOfWork unit, IRepository<ProductCategory> repo) : base(unit, repo)
        {
        }

        public async Task<ProductCategory> GetWithProductByIdAsync(int procatId)
        {
            return await _unit.ProductCategory.GetWithProductByIdAsync(procatId);
        }
    }
}
