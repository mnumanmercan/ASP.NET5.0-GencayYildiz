using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;
using OrnekUygulama.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult GetProducts()
        {
        
            return View();

        }
        public IActionResult CreateProduct()
        {
            var product = new Product
            {
                ProductName = "B product",
                Quantity = 25
            };
            return View(product);
        }
        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName,string txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
