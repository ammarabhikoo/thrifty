using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace tpi_website.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        [Display(Name = "Product Name")]
        public string ProductType { get; set; }
        [Display(Name = "Product Category")]
        public decimal Price { get; set; }
        public string Quantity { get; set; }

    }
}
