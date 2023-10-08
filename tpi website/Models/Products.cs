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


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Quantity must be a positive whole number.")]
        public string Quantity { get; set; }

    }
}
