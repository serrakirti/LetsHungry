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
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        private readonly int[] _int;

        public OrderSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order { Id=_int[0], ProductId = _int[0], FinalPrice=100, UserId = _int[0] },

               new Order { Id = _int[1], ProductId = _int[1], FinalPrice = 50, UserId = _int[1] }

                );
        }
    }
}
