﻿using Microsoft.AspNetCore.Mvc;

namespace FurniturWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Shop() { 
            return View();
        }
    }
}
