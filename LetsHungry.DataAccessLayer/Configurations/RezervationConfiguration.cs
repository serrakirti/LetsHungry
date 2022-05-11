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
    public class RezervationConfiguration : IEntityTypeConfiguration<Rezervation>
    {
        public void Configure(EntityTypeBuilder<Rezervation> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Guest).IsRequired();
            builder.Property(p => p.RezervationDate).IsRequired();
            builder.Property(p => p.RestaurantId).IsRequired();
            builder.Property(p => p.OrderId).IsRequired();
            builder.HasOne(p => p.Restaurant).WithMany(c => c.Rezervations).HasForeignKey(p => p.RestaurantId);
            builder.HasOne(p => p.Order).WithMany(c => c.Rezervations).HasForeignKey(p => p.OrderId);

        }
    }
}
