using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsHungry.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsHungry.DataAccessLayer.Seeds
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        private readonly int[] _int;

        public LocationSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location { Id = _int[0], Name = "Aydın", },

                new Location { Id = _int[1], Name = "Mersin", }

            );
        }
    }
}