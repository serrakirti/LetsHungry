using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryId { get; set; }
        public int RestaurantId { get; set; }
        public virtual ProductCategory ProductCategories { get; set; }
        public virtual Restaurant Restaurants { get; set; }
        public ICollection<Order> Orders { get; set; }



    }
}
