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

        #region JSONResult
        public JsonResult GetProducts()
        {
            JsonResult result = Json(new Product
            {
                id = 5,
                ProductName = "Terlik",
                Quantity = 15
            });
            return result;
        }
        #endregion

        #region EmptyResult
        public EmptyResult GetProduct()
        {
            return new EmptyResult();
        }
        #endregion
    }
}
