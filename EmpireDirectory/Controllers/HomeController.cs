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
        /*
        public ActionResult Details(int id)
        {
            string type = characters.Where(x => x.ID == id).FirstOrDefault().GetType().ToString();
            if (type == "EmpireDirectory.Models.Jedi")
            {
                return RedirectToAction("JediDetail/" + id); //, new { id = id }
            }
            else if(type=="EmpireDirectory.Models.BountyHunder")
            {
                return RedirectToAction("BountyHunterDetail/" + id);
            }
            //If it gets here you got an error
            return View();
        }
        */
        public ActionResult Details(int id)
        {
            /*
            Jedi empty = new Jedi();
            string res = empty.GetType().ToString();
            Jedi anotherJedi = (Jedi)jedi; //casting jedi to Jedi from Character
            ---
            Jedi jedi = (Jedi)characters.Where(x => x.ID == id && x.GetType().ToString()=="EmpireDirectory.Models.Jedi").FirstOrDefault(); //Linq statement - lamba
            */
            Character character = characters.Where(x => x.ID == id).FirstOrDefault();
            return View(character);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}