using LetsHungry.Core.IntRepository;
using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.IntRepository
{
    public interface IProductCategoryRepository:IRepository<ProductCategory>
    {
        Task<ProductCategory> GetWithProductByIdAsync(int procatId);
    }
}
