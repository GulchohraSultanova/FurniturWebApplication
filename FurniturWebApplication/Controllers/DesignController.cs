using FurniturWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FurniturWebApplication.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()

        {
            List<Furniture> furnitures = new List<Furniture>()
            {
                  new Furniture { Name = "Chair", Price = 400 },
                  new Furniture { Name = "Armchair", Price = 500 },
                  new Furniture { Name = "Table", Price = 600 },
                  new Furniture {Name="Sofa", Price=900},
                  new Furniture {Name="Bed", Price=900},
                  new Furniture {Name="Sofaaa", Price=1000},
            };
            ViewBag.Furnitures = furnitures;
            return View();
        }
    }
}
