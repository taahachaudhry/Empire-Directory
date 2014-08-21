using EmpireDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpireDirectory.Controllers
{
    public class HomeController : Controller
    {
        List<Character> characters = Singleton.Instance.Characters;
        public ActionResult Index()
        {
            int RandomNum = new Random().Next(characters.Count());
            HomeIndexVM bucket = new HomeIndexVM();
            bucket.Characters = characters;
            bucket.FeauturedCharacter = bucket.Characters[RandomNum];

            return View(bucket);
        }
        [HttpGet]
        public ActionResult AddJedi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJedi(string name, Affiliation affiliation)
        {
            Jedi jedi = new Jedi();
            jedi.Name = name;
            jedi.Affiliation = affiliation;
            characters.Add(jedi);

            return RedirectToAction("Index");
        }

        public ActionResult JediDetail(int id)
        {
            characters[0].ID = 0;
            //Jedi empty = new Jedi();
            //string res = empty.GetType().ToString();
            Jedi jedi = (Jedi)characters.Where(x => x.ID == id && x.GetType().ToString()=="EmpireDirectory.Models.Jedi").FirstOrDefault(); //Linq statement - lamba

            // Jedi anotherJedi = (Jedi)jedi; //casting jedi to Jedi from Character

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}