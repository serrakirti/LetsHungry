using LetsHungry.Core.IntRepository;
using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.IntRepository
{
    public interface IOrderRepository:IRepository<Order>
    {
        Task<Order> GetWithRezervationByIdAsync(int orId);
    }
}
