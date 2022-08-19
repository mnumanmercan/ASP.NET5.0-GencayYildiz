using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models.ModelMetadataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekUygulama.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
       
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
