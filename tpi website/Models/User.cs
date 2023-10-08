using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace tpi_website.Models
{ 
    public class User
    {
        
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must have exactly 10 digits.")]
        public int Phone { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Age must be a positive whole number.")]
        public int Age { get; set; }

        public string City { get; set; }
    }
}
