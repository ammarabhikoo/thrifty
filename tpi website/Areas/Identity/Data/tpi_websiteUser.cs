using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;



namespace tpi_website.Areas.Identity.Data;

// Add profile data for application users by adding properties to the tpi_websiteUser class
public class tpi_websiteUser : IdentityUser
{


    public string FullName { get; set; }

    [Display(Name = "Moblie Number")]
    [RegularExpression("^[0-9]{10}$", ErrorMessage = "Invalid Mobile number")]
    public string? PhoneNumber { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Age must be a positive whole number.")]
    public int Age { get; set; }
}

