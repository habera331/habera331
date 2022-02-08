using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShop.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Bestseller { get; set; }
        public bool IsVisible { get; set; }
        public IdentityUser Owner { get; set; }
    }
}
