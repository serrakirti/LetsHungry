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
        Task CommitAsync(); 
        void Commit(); 
    }
}
