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
       

        

        public IActionResult GetProducts()
        {
        
            return View();

        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            if (!ModelState.IsValid)
            { // dogrulamalarda hata-eksik varsa

                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
                var messages = ModelState.ToList(); 
                return View(model);
            }

            return View();
        }


    }
}
