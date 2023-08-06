using System.ComponentModel.DataAnnotations;

namespace tpi_website.Models
{
    public class Order
    {

        public int Id { get; set; }

        [Display(Name = "Customer ID")]
        public int Customer_ID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime Ship_date { get; set; }

        [Display(Name = "Order Date")]
        public string? Status { get; set; }

        [Display(Name = "Street Address")]
        public string? To_street { get; set; }
        [Display(Name = "City")]
        public string? To_city { get; set; }
        [Display(Name = "Postcode")]
        public int To_zip { get; set; }

        [Display(Name = "Product ID")]
        public int Product_ID { get; set; }
        
    }
}
