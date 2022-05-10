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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.ProductCategoryId).IsRequired();
            builder.Property(x => x.RestaurantId).IsRequired();
            builder.HasOne(p => p.ProductCategories).WithMany(c => c.Products).HasForeignKey(p => p.ProductCategoryId);
            builder.HasOne(p => p.Restaurants).WithMany(c => c.Products).HasForeignKey(p => p.RestaurantId);



        }
    }
}
