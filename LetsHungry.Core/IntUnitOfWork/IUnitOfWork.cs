using LetsHungry.Core.IntRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.IntUnitOfWork
{
    public interface IUnitOfWork
    {       
        IRestaurantRepository Restaurant{ get; }
        ICategoryRepository Category { get; }
        IProductCategoryRepository ProductCategory { get; }
        IProductRepository Product { get; }
        IUserRepository User { get; }
        IRezervationRepository Rezervation { get; }
        ICommentRepository Comment { get; }
        IRaitingRepository Raiting { get; }
        IOrderRepository Order { get; }
        Task CommitAsync(); 
        void Commit(); 
    }
}
