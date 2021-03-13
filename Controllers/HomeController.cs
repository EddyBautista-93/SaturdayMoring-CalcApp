using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaturdayMoring_CalcApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SaturdayMoring_CalcApp.Controllers
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
        public IActionResult Calculate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Calculate(string firstNumber, string secondNumber, string cal)
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            int c = 0;

            switch (cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
