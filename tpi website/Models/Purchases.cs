using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tpi_website.Areas.Identity.Data;

namespace tpi_website.Models
{
    public class Purchases
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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime OrderDate { get; set; }

        

    }
}
