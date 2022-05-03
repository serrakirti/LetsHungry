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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _int;

        public CategorySeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id=_int[0],Title="Et Yemekleri", Description="Kırmızı Et",},

                new Category { Id = _int[1], Title = "Sebze Yemekleri", Description = "Meyveler", }

                );
        }
    }
}
