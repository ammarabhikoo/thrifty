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
        public int Phone { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
