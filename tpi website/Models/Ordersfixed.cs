using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tpi_website.Areas.Identity.Data;

namespace tpi_website.Models
{

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class MustBeCurrentDateTimeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dateTime)
            {
                // Check if the provided date is close enough to the current date and time
                // You can define a tolerance in seconds if needed
                TimeSpan tolerance = TimeSpan.FromSeconds(300); // Adjust tolerance as needed
                DateTime currentDateTime = DateTime.Now;
                return Math.Abs((currentDateTime - dateTime).TotalSeconds) <= tolerance.TotalSeconds;
            }

            return false; // Property is not a DateTime
        }
    }
    public class Ordersfixed
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Street Address")]
        public string To_street { get; set; }

        [Display(Name = "City")]
        public string To_city { get; set; }

        [Display(Name = "Postcode")]
        [Required(ErrorMessage = "ZIP code is required.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "ZIP code must consist of exactly four digits.")]
        public int To_zip { get; set; }

        [Display(Name = "Order Date")]
        [MustBeCurrentDateTime(ErrorMessage = "Order Date must be the current date and time.")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Product Names")]
        public string ProductName { get; set; }



    }
}

