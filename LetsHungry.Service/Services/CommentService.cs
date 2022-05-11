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
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(IUnitOfWork unit, IRepository<Comment> repo) : base(unit, repo)
        {
        }

        public async Task<Comment> GetWithUserByIdAsync(int comId)
        {
            return await _unit.Comment.GetWithUserByIdAsync(comId);
        }
    }
}
