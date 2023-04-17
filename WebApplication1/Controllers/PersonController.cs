using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(string id, string navn)
        {

            if (!String.IsNullOrEmpty(id))
                ViewBag.id = id;
            else
                ViewBag.id = "no id";

            if (!String.IsNullOrEmpty(navn))
                ViewBag.navn = navn;
            else
                ViewBag.navn = "intet navn";

            return View();
        }

        public ActionResult find(string fornavn, string efternavn)
        {
            //Find person med id = id
            Person p = new Person();
            p.Fornavn = fornavn;
            p.Efternavn = efternavn;
            p.Alder = 35;
            return View("find", p);
        }

        public ActionResult create(string fornavn, string efternavn, int alder) //Skal muligvis gøre noget her. Kommer ikke over på posten.
        {

            Person p = new Person();
            p.Fornavn = fornavn;
            p.Efternavn = efternavn;
            p.Alder = alder;
            return View("create", p);

        }

        [HttpPost]
        public ActionResult PersonCreatedCollection(IFormCollection formCollection)
        {
            string fornavn = formCollection["Fornavn"];
            string efternavn = formCollection["Efternavn"];
            int alder = int.Parse(formCollection["Alder"]);
            Person p = new Person(fornavn, efternavn, alder);
            ViewBag.p = p;


            return View("PersonCreatedCollection");
        }


    }
}
