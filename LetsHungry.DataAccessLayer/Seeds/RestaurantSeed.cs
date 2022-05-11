using LetsHungry.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer.Seeds
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        private readonly int[] _int;

        public RestaurantSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
               new Restaurant { Name="Yeşilçam", LocationId=_int[0] ,Address="Gaziosmanpaşa", Tel="02546569898", Detail="cafe-restaurant", Id=_int[0], CategoryId=_int[0]},
               new Restaurant { Name = "Times", LocationId = _int[1], Address = "Gaziosmanpaşa", Tel = "02546569898", Detail = "cafe-restaurant", Id = _int[1], CategoryId = _int[1] }
              );
        }
    }
}
