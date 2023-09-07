namespace tpi_website.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }

        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }
        public string OrderStatus { get; set; }

    }
}
