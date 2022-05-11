using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LetsHungry.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer.Seeds
{
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        private readonly int[] _int;

        public CommentSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment { Id = _int[0], Text="Yemekten Böcek çıktı.",CommentDate=DateTime.Now, UserId = _int[0], RestaurantId = _int[0] },

                new Comment { Id = _int[1], Text = "Yemekler soğuktu.", CommentDate = DateTime.Now, UserId=_int[1],RestaurantId= _int[1] }

                );
        }
    }
}
