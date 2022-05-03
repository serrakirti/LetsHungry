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
                new Restaurant { Name="Yeşilçam", City="istanbul",Address="Gaziosmanpaşa", Tel="02546569898", Detail="cafe-restaurant", Id=1, CategoryId=_int[0], CommentId=_int[0],MenuId=_int[0]},

                new Restaurant { Name = "Jhonny Bravo", City = "Sakarya", Address = "Serdivan", Tel = "02546569898", Detail = "cafe", Id = 2, CategoryId = _int[0], CommentId = _int[0], MenuId = _int[0] },

                 new Restaurant { Name = "White Rabbit", City = "Aydın", Address = "Efeler", Tel = "02546569898", Detail = "cafe", Id = 3, CategoryId = _int[1], CommentId = _int[1], MenuId = _int[1] },

                  new Restaurant { Name = "Urfalı Babonun Yeri", City = "istanbul", Address = "Zeytinburnu", Tel = "02546569898", Detail = "Restaurant", Id = 4, CategoryId = _int[1], CommentId = _int[1], MenuId = _int[1] }


                );
        }
    }
}
