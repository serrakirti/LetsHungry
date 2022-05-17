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
    public class RaitingService : Service<Raiting>, IRaitingService
    {
        public RaitingService(IUnitOfWork unit, IRepository<Raiting> repo) : base(unit, repo)
        {
        }

        public async Task<Raiting> GetWithUserByIdAsync(int raitId)
        {
            return await _unit.Raiting.GetWithUserByIdAsync(raitId);
        }
    }
}
