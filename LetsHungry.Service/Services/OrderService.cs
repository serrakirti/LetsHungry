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
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unit, IRepository<Order> repo) : base(unit, repo)
        {
        }

        public async Task<Order> GetWithRezervationByIdAsync(int orId)
        {
            return await _unit.Order.GetWithRezervationByIdAsync(orId);
        }
    }
}
