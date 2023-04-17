using Microsoft.AspNetCore.Mvc;

namespace Øvelse11._1.Controllers
{
    public class RockBandsController : Controller
    {
        public IActionResult Index()
        {
            string[] rockBands = new string[10];
            rockBands[0] = "AA";
            rockBands[1] = "BB";
            rockBands[2] = "CC";
            rockBands[3] = "DD";
            rockBands[4] = "EE";
            rockBands[5] = "FF";
            rockBands[6] = "GG";
            rockBands[7] = "HH";
            rockBands[8] = "II";
            rockBands[9] = "JJ";

            ViewBag.rockBands = rockBands;

            return View();
        }
    }
}
