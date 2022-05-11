using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public ICollection<Comment> Comments { get; set; }    
        public ICollection<Raiting> Raitings { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
