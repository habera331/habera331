using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoeShop.Models;
using ShoeShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShop.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


       
        [HttpGet]
        public async Task<IActionResult> List(string name)
        {
            var products = await _productService.GetAll(name);
            return View(products);
        }
    }
}