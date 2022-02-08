using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoeShop.Entities;
using ShoeShop.Models;

namespace ShoeShop.Services
{
    public interface IProductService
    {
        Task Add(ProductModel product);

        Task<IEnumerable<ProductEntity>> GetAll(string name);
    }
}
