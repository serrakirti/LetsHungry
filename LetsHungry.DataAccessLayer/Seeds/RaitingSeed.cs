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
    public class RaitingSeed : IEntityTypeConfiguration<Raiting>
    {
        private readonly int[] _int;

        public RaitingSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Raiting> builder)
        {
            builder.HasData(
                new Raiting { Id=_int[0], UserId = _int[0], RestaurantId = _int[0], HoldOnStar = 1 },

                new Raiting { Id = _int[1], UserId = _int[1], RestaurantId = _int[1], HoldOnStar = 5 }

                );
        }
    }
}
