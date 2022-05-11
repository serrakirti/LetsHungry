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
    public class RezervationSeed : IEntityTypeConfiguration<Rezervation>
    {
        private readonly int[] _int;

        public RezervationSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Rezervation> builder)
        {
            builder.HasData(
                new Rezervation { Id=_int[0],RezervationDate=DateTime.Now, Guest=_int[0], RestaurantId=_int[0],OrderId=_int[0]},

               new Rezervation { Id = _int[1], RezervationDate = DateTime.Now, Guest = _int[1], RestaurantId = _int[1], OrderId = _int[1] }

                );
        }
    }
}
