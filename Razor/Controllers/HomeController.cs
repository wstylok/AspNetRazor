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
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductId = 1,
                Name = "Kajak",
                Description = "Jednnosobowy kajak",
                Price = 275M,
                Category = "Sporty wodne"
            };

            return View(myProduct);
        }
    }
}
