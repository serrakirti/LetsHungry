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
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasKey(p => p.Id);           
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.LocationId).IsRequired();
            builder.Property(p => p.Tel).IsRequired();
            builder.Property(p => p.Detail).IsRequired();      
           // builder.Property(p => p.MenuId).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.Address).IsRequired();
            builder.HasOne(p => p.Category).WithMany(c => c.Restaurants).HasForeignKey(p => p.CategoryId);
            builder.HasOne(p => p.Location).WithMany(c => c.Restaurants).HasForeignKey(p => p.LocationId);

        }
    }
}
