using LetsHungry.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer.Configurations
{
    public class RaitingConfiguration : IEntityTypeConfiguration<Raiting>
    {
        public void Configure(EntityTypeBuilder<Raiting> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.UserId).IsRequired();
            builder.Property(x => x.RestaurantId).IsRequired();
            builder.Property(x => x.HoldOnStar).IsRequired();
            builder.HasOne(p => p.User).WithMany(c => c.Raitings).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Restaurant).WithMany(c => c.Raitings).HasForeignKey(p => p.RestaurantId);

        }
    }
}
