﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.Core.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
