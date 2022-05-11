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
    public class ProductCategorySeed : IEntityTypeConfiguration<ProductCategory>
    {
        private readonly int[] _int;

        public ProductCategorySeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(
                new ProductCategory { Id=_int[0],Name="Atıştırmalıklar"},

                new ProductCategory { Id = _int[1], Name = "Atıştırmamalıklar" }

                );
        }
    }
}
