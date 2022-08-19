using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekUygulama.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Lutfen product name'i girin.")]
        [StringLength(100,ErrorMessage ="En fazla 100 karakter giriniz")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage ="Lutfen dogru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
