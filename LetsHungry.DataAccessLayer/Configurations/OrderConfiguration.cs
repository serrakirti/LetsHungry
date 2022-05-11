using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsHungry.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsHungry.DataAccessLayer.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.FinalPrice).IsRequired();
            builder.Property(p => p.UserId).IsRequired();
            builder.HasOne(p => p.Product).WithMany(c => c.Orders).HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.User).WithMany(c => c.Orders).HasForeignKey(p => p.UserId);
        }
    }
}
