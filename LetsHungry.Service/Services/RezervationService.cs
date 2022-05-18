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
    public class RezervationService : Service<Rezervation>, IRezervationService
    {
        public RezervationService(IUnitOfWork unit, IRepository<Rezervation> repo) : base(unit, repo)
        {
        }

        public async Task<Rezervation> GetWithOrdersByIdAsync(int rezId)
        {
            return await _unit.Rezervation.GetWithOrdersByIdAsync(rezId);
        }
    }
}
