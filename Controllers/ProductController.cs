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
        public class QueryData
        {
            public int A { get; set; }
            public string B { get; set; }
            
        }

        //public class RouteData
        //{
        //    public string A { get; set; }
        //    public string B { get; set; }

        //    public string id { get; set; }
        //}

        public class AjaxData
        {
            public string A { get; set; }
            public string B { get; set; }
        }


        public IActionResult GetProducts()
        {
        
            return View();

        }
        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix = "Item1")]Product product, [Bind(Prefix = "Item2")]User user)
        {
            return View();
        }


    }
}
