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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {

        private readonly int[] _int;

        public ProductSeed(int[] @int)
        {
            _int = @int;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = _int[0], Name = "Köri Soslu Tavuk", Price = 42, IsActive = true, ProductCategoryId = _int[0], RestaurantId = _int[0] },
                new Product { Id = _int[1], Name = "Barbekü Soslu Tavuk", Price = 40, IsActive = true, ProductCategoryId = _int[1], RestaurantId = _int[1] }



            );
        }
    }
}
