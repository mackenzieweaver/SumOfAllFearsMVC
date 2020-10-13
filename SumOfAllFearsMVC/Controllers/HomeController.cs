using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SumOfAllFearsMVC.Models;

namespace SumOfAllFearsMVC.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Solution()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solution(int k)
        {
            int[] arr = { 10, 15, 3, 7 };
            var result = new StringBuilder();
            for(int i = 0; i < arr.Length; i++)
            {
                var test = k - arr[i];
                if(arr.Contains(test))
                {
                    result.Append(arr[i].ToString() + " and " + test.ToString());
                    break;
                }
            }
            ViewData["Data"] = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
