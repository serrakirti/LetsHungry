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
    public class RezervationRepository : Repository<Rezervation>, IRezervationRepository
    {
        public RezervationRepository(LetsHungryDbContext db) : base(db)
        {
        }
        public async Task<Rezervation> GetWithOrdersByIdAsync(int rezId)
        {
            return (await _db.Rezervations.Include(s => s.Order).FirstOrDefaultAsync(s => s.Id == rezId))!;
        }
    }
}
