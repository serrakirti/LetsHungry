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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(LetsHungryDbContext db) : base(db)
        {
        }

        public async Task<Comment> GetWithUserByIdAsync(int comId)
        {
            var comment = _db.Comments.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == comId);
            return (await comment)!;
        }
    }
}
