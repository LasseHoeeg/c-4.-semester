using Microsoft.AspNetCore.Mvc;
using Øvelse2PartialView.Models;
using System.Diagnostics;

namespace Øvelse2PartialView.Controllers
{
    public class HomeController : Controller
    {


        private List<Person> AllePersoner()
        {
            List<Person> personer = new List<Person>
            {
                new Person("Bo"),
                new Person("Bob"),
                new Person("Karl"),
                new Person("Bent")
            };

            return personer;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult VisAlle()
        {
            return View(AllePersoner());
        }

        public IActionResult VisEn()
        {
            return View("VisEn",AllePersoner()[0]);
        }

    }
}