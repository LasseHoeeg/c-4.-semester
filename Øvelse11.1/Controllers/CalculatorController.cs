using Microsoft.AspNetCore.Mvc;

namespace Øvelse11._1.Controllers
{
    public class CalculatorController : Controller
    {
        //Øvelse 11.4 
        //Post-method
        //action-method=/Calculator/index
        //<form action="/Calculator/index" method="post">     

        //Metode og action har ikke id så vidt jeg kan se, men input felterne har + andet.
        [HttpGet]
        public IActionResult Index() //Kan kun få lov til at kalde viewet Index. Kan ikke se det ellers. 
            //Metodenavnet skal være det samme som det view man vil kalde
        {
            return View();
        }

     
 
        [HttpPost]
        public ActionResult TimeCalculator(IFormCollection formCollection)
        {
            ViewBag.Hours = int.Parse(formCollection["Hours"]);
            ViewBag.Minutes = int.Parse(formCollection["Minutes"]);
            ViewBag.Seconds = int.Parse(formCollection["Seconds"]);


            int hours = ViewBag.Hours;
            int minutes = ViewBag.Minutes;
            int seconds = ViewBag.Seconds;

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;
            ViewBag.Total = total;
            

            return View("TimeCalculator"); 
        }


    }
}
