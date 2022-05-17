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
    public class RaitingRepository : Repository<Raiting>, IRaitingRepository
    {
        public RaitingRepository(LetsHungryDbContext db) : base(db)
        {
        }

        public async Task<Raiting> GetWithUserByIdAsync(int raitId)
        {
            var raiting = _db.Raitings.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == raitId);
            return (await raiting)!;
        }
    }
}
