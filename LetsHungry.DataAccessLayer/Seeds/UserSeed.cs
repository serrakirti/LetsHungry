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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _int;

        public UserSeed(int[] @int)
        {
            _int = @int;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id=_int[0],Name="Serra", UserName="Serra",Password="1234",Mail="serra@gmail.com",Tel="5555555555"},

                new User { Id = _int[1], Name = "Hüseyin", UserName = "Huseyin", Password = "1234", Mail = "huseyin@gmail.com", Tel = "1111111111" }

                );
        }
    }
}
