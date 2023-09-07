using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace tpi_website.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Category")]
        public string ProductType { get; set; }
      
        public decimal Price { get; set; }
        public string Quantity { get; set; }

    }
}
