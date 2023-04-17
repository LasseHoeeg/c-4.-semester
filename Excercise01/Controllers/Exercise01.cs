using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace Excercise01.Controllers
{
    public class Exercise01 : Controller
    {
        List<SelectListItem> countriesList = new List<SelectListItem>();

        public IActionResult Index(string Countries)
        {

            if (HttpContext.Session.GetString("Countries") == null) { 
            countriesList.Add(new SelectListItem { Text = "China", Value = "CN" });
            countriesList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
                string json = JsonSerializer.Serialize(countriesList);
                HttpContext.Session.SetString("Countries", json);

        }
            else
            {
                string json = HttpContext.Session.GetString("Countries");
                countriesList = JsonSerializer.Deserialize<List<SelectListItem>>(json);

            }
            ViewBag.Countries = countriesList;
            ViewBag.CountryCode = Countries;

            return View();
        }

        [HttpPost]
        public ActionResult Index(IFormCollection formData) {

            string json = HttpContext.Session.GetString("Countries");
            countriesList = JsonSerializer.Deserialize<List<SelectListItem>>(json);

            ViewBag.NewCountry = formData["Country"];
            ViewBag.NewCode = formData["Code"];
            string country = ViewBag.NewCountry;
            string code = ViewBag.NewCode;
            countriesList.Add(new SelectListItem { Text = country, Value = code });

            json = JsonSerializer.Serialize(countriesList);
            HttpContext.Session.SetString("Countries", json);

            ViewBag.Countries = countriesList;
           
            return View("Index");
        
        }
    }
}
