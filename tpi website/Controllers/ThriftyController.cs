﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace tpi_website.Controllers
{
    public class ThriftyController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}

