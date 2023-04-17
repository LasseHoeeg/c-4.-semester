using Microsoft.AspNetCore.Mvc;
using Øvelse1PartialViews.Models;
using System.Diagnostics;

namespace Øvelse1PartialViews.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sale()
        {
            return View();
        }

        public IActionResult MoreSales()
        {
            return View();
        }

        public IActionResult Buy()
        {
            return View();
        }
        public IActionResult BuyAndSell()
        {
            return View();
        }

    }
}