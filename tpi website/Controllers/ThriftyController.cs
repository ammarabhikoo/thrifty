using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace tpi_website.Controllers;

    public class ThriftyController : Controller
    {
    // 
    // GET: /Thrifty/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Thrifty/Welcome/ 
    public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }


