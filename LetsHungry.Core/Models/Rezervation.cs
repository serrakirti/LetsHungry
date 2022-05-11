using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class Rezervation
    {
        public int Id { get; set; }
        public DateTime? RezervationDate { get; set; }
        public int Guest { get; set; }
        public int RestaurantId { get; set; }
        public int OrderId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Order Order { get; set; }


    }
}
