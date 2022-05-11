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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(p => p.Id);           
            builder.Property(p => p.Text).IsRequired();
            builder.Property(p => p.CommentDate).IsRequired();
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p=>p.RestaurantId).IsRequired();
            builder.HasOne(p => p.User).WithMany(c => c.Comments).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Restaurant).WithMany(c => c.Comments).HasForeignKey(p => p.RestaurantId);

        }
    }
}
