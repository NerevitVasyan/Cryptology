using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public List<Person> Persons = new List<Person>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Person()
        {           
            Persons.Add(new Person { Name = "Vita" });
            Persons.Add(new Person { Name = "Niki" });
            Persons.Add(new Person { Name = "Mikiop" });          

            ViewBag.Persons = Persons;
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(Person p)
        {
            Persons.Add(p);
            ViewBag.Persons = Persons;
            return RedirectToAction("Person");
        }

    }
}