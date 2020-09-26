using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstASPCoreApp.Models;

namespace FirstASPCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IList<string> fruits = new List<string>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //comment for Index method
        public IActionResult Index()
        {
            return View();
        }
        //Comment added for privacy
        public IActionResult Privacy()
        {
            return View();
        }
        
        //Comment Added
        public string msg()
        {
            return "Parisha";
        }
        public string welcome()
        {
            return "welcome";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ShowFruits()
        {
            fruits.Add("Apple");
            fruits.Add("Lemon");
            fruits.Add("Banana");
            fruits.Add("Kiwi");
            ViewBag.Fr = fruits;
            return View();
        }
    }
}
