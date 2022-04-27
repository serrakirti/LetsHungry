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
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unit, IRepository<User> repo) : base(unit, repo)
        {
        }

        public async Task<User> GetWithCommentByIdAsync(int usId)
        {
           return await _unit.User.GetWithCommentByIdAsync(usId);
        }
    }
}
