using System.ComponentModel.DataAnnotations;
using static tpi_website.Controllers.OrdersController;
using System;
using System.ComponentModel.DataAnnotations;

namespace tpi_website.Models
{
    public class Order
    {

        public int Id { get; set; }


        [Display(Name = "Full Name")]
        public string FullName { get; set; }


        [Display(Name = "Order Date")]
        public DateTime Ship_date { get; set; }

        [Display(Name = "Order Status")]
        public string Status { get; set; }

        [Display(Name = "Street Address")]
        public string To_street { get; set; }
        [Display(Name = "City")]
        public string To_city { get; set; }
        
        [Display(Name = "Postcode")]
        [Required(ErrorMessage = "ZIP code is required.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "ZIP code must consist of exactly four digits.")]
        public int To_zip { get; set; }

        [Display(Name = "Product Names")]
        [Required(ErrorMessage = "Product Names are required.")]
        public List<string> ProductNames { get; set; }

        public Order()
        {
            // Automatically fill Ship_date with the current date and time
            Ship_date = DateTime.Now;

            // Automatically fill Status with "Processing"
            Status = "Processing";

        }
    }


    
}

