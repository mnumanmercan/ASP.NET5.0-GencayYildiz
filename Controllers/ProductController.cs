using Microsoft.AspNetCore.Http;
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
        public class Model
        {
            public string txtValue1 { get; set; }

            public string txtValue2 { get; set; }

            public string txtValue3 { get; set; }
        }
        public class MyClass
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
        }
        
        public IActionResult GetProducts()
        {
        
            return View();

        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(MyClass product)
        {
            
            return View();
        }

    }
}
