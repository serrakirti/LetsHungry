using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class Raiting
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public int HoldOnStar { get; set; }
        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        


    }
}
