using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Øvelse11._1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
        

            return View();
        }


        public IActionResult Index1()
        {
            string name;
            int age;
            DateTime birthDay;

            name = "Peter";
            age = 12;
            birthDay = new DateTime(2011, 01, 01);

            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.birthday = birthDay;
            //I videoen er der noget med viewData, bliver dog ikke nævnt i opg. 11.2

            return View();
        }
    }
}
