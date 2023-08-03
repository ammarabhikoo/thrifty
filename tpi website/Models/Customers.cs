using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi_website.Models
{
    public class Customers
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
      
        public string City { get; set; }
    }

  
}
