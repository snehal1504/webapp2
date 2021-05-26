using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webapp2.Models;

namespace webapp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewBag.MyProp = "Snehal";
            ViewBag.MyList = new List<string>() { "View", "Bag", "Dynamic", "Property" };
            List<Category> clist = new List<Category>()
            {
                new Category(){ Name = "Packet" , Id=11, DisplayOrder = 41},
                new Category(){ Name = "Packet1" , Id=12, DisplayOrder = 42},
                new Category(){ Name = "Packet2" , Id=13, DisplayOrder = 43},
                new Category(){ Name = "Packet3" , Id=14, DisplayOrder = 44}
            };
            ViewBag.MyClist = clist;


            ViewData["MyKey"] = "This is View Data!!";

            ViewData["MyList"] = new List<string>() { "View", "Data", "Works", "Dictionary" };

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
