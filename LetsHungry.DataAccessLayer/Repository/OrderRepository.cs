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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(LetsHungryDbContext db) : base(db)
        {
        }

        public async Task<Order> GetWithRezervationByIdAsync(int orId)
        {
            var order = _db.Orders.Include(s => s.Rezervations).FirstOrDefaultAsync(s => s.Id == orId);
            return (await order)!;
        }
    }
}
