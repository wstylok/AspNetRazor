using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product[] products =
            {
                new Product {Name="Kajak", Price=275M},
                new Product {Name="Kamizelka ratunowa", Price=48.95M},
                new Product {Name="Piłka nożna", Price=19.50M},
                new Product {Name="Rękawice bramkarskie", Price=39.90M}
            };
            
            return View(products);
        }
    }
}
