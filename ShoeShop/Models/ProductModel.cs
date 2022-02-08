using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShop.Models
{
    public class ProductModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Bestseller { get; set; }
        public bool IsVisible { get; set; }
    }
}
