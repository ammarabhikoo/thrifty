using System.ComponentModel.DataAnnotations;

namespace tpi_website.Models
{
    public class Order
    {

        public int Id { get; set; }
        public int Customer_ID { get; set; }

        public DateTime Ship_date { get; set; }
        public string? Customer_name { get; set; }
        public string? To_street { get; set; }
        public string? To_city { get; set; }
        public int To_zip { get; set; }
        public int Product_ID { get; set; }
    }
}
