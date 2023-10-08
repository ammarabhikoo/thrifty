using System.ComponentModel.DataAnnotations;
using static tpi_website.Controllers.OrdersController;
using System;
using System.ComponentModel.DataAnnotations;

namespace tpi_website.Models
{
    public class Order
    {

        public int Id { get; set; }


        [Display(Name = "Customer ID")]
        [Required(ErrorMessage = "Customer ID is required.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Customer ID must be a positive whole number.")]
        [Range(1, int.MaxValue, ErrorMessage = "Customer ID must be a positive whole number.")]
        public int Customer_ID { get; set; }


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

        [Display(Name = "Product ID")]
        [Required(ErrorMessage = "Product ID is required.")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Product ID must be a positive whole number.")]
        [Range(1, int.MaxValue, ErrorMessage = "Product ID must be a positive whole number.")]
        public int Product_ID { get; set; }
        
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
