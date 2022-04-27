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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(LetsHungryDbContext db):base(db)
        {

        }

        public async Task<User> GetWithCommentByIdAsync(int usId)
        {
            return (await _db.Users.Include(s => s.Comments).FirstOrDefaultAsync(s => s.Id == usId))!;
        }
    }
}
