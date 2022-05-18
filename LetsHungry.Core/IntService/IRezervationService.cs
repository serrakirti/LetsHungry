using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.IntService
{
    public interface IRezervationService:IService<Rezervation>
    {
        Task<Rezervation> GetWithOrdersByIdAsync(int rezId);
    }
}
