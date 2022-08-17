using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<Product>
            {
                new Product{id = 1, ProductName = "A Product", Quantity = 10},
                new Product{id = 2, ProductName = "B Product", Quantity = 15},
                new Product{id = 3, ProductName = "C Product", Quantity = 20}
            };

            #region Model Bazli Veri Gonderimi
            //return View(products);
            #endregion

            #region Veri Taşıma Kontrolleri

            #region ViewBag

            #endregion

            #region ViewData

            #endregion

            #region TempData

            #endregion

            #endregion


            return View();
        }
    }
}
