using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.IntRepository
{
    public interface ICommentRepository:IRepository<Comment>
    {
        Task<Comment> GetWithUserByIdAsync(int comId);
    }
}
