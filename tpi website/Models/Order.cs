using System.ComponentModel.DataAnnotations;

using System;
using Newtonsoft.Json.Linq;

namespace tpi_website.Models
{
    public class Order
    {

        public int Id { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Customer Name is required.")]
        
        public string Customer_ID { get; set; }


        [Display(Name = "Order Date")]
        [DateNotInPast(ErrorMessage = "Order date cannot be in the past.")]
        public DateTime Ship_date { get; set; }

        [Display(Name = "Order Status")]
        public string? Status { get; set; }

        [Display(Name = "Street Address")]
        public string? To_street { get; set; }
        [Display(Name = "City")]
        public string? To_city { get; set; }

        [Display(Name = "Postcode")]
        [Required(ErrorMessage = "ZIP code is required.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "ZIP code must consist of exactly four digits.")]
        public int To_zip { get; set; }

        [Display(Name = "Product Names")]
        [Required(ErrorMessage = "Product is required.")]
        
        public string Product_ID { get; set; }

        public Order()
        {
            

            // Automatically fill Status with "Processing"
            Status = "Processing";

            
        }

    }

    public class DateNotInPastAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)

        {
            if (value is DateTime date)
            {
                // Compare the date to today's date
                return date >= DateTime.Today;
            }
            return false; // Return false for non-DateTime values



        }
    }
}

