using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal FinalPrice { get; set; }
        public int UserId { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public ICollection<Rezervation> Rezervations { get; set; }
    }
}
