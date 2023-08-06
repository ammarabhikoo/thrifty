using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace tpi_website.Models
{ 
    public class User
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Display(Name = "First Name")]
        public string LastName { get; set; }
        [Display(Name = "Last Name")]
        public int Phone { get; set; }
        [Display(Name = "Product Number")]
        public string Email { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
