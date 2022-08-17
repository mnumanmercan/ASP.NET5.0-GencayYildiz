using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
            //View'e gonderilecek datayı dinamik tanımlı bir degiskenle taşınmasını saglayan kontrol
            //ViewBag.products = products;
            #endregion

            #region ViewData
            // ViewBag gibi actiondaki datayi view'e taşımayı saglar
            // ViewBag'den farkı 
            //ViewData["product"] = products;
            #endregion


            #region TempData
            //Bu da viewData ya benzer
            string data = JsonSerializer.Serialize(products); // bu sekilde veri json formata cevirilip kompleks olmaktan cıkar ve temp data ile yönlendirilen action da kullanılır 
            TempData["products"] = data;

            //TempData["x"] = 5;
            //ViewBag.x = 5;
            //ViewData["x"] = 5;
            #endregion

            #endregion


            return RedirectToAction("Index2", "Product");
        }

        public IActionResult Index2()
        {
            // var v1 = ViewBag.x;
            // var v2 = ViewData["x"];
            // var v3 = TempData["x"];

            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
            return View();
        }

    }
}
