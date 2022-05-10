using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
        //public int CommentId { get; set; }
      
        public virtual Category Category { get; set; }
        // public virtual Comment Comment { get; set; }
        public virtual Location Location { get; set; }

        public ICollection<Rezervation> Rezervations { get; set; }
        public ICollection<Raiting> Raitings { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
