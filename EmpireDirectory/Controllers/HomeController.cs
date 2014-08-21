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
        public ActionResult AddJedi(string name, Affiliation affiliation, string image)
        {
            Jedi jedi = new Jedi();
            jedi.Name = name;
            jedi.Affiliation = affiliation;
            jedi.Image = image;
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
            Jedi jedi = (Jedi)characters.Where(x => x.ID == id && x.GetType().ToString()=="EmpireDirectory.Models.Jedi").FirstOrDefault(); //Linq statement - lambda
            */
            Character character = characters.Where(x => x.ID == id).FirstOrDefault();
            return View(character);
        }
        public ActionResult Edit(int id)
        {
            Character character = characters.Where(x => x.ID == id).FirstOrDefault();
            return View(character);
        }
        [HttpPost]
        public ActionResult Edit(Jedi jedi, BountyHunter bountyhunter)
        {
            var character = characters.Where(x => x.ID == jedi.ID).FirstOrDefault();
            if (character.GetType().ToString() == "EmpireDirectory.Models.Jedi")
            {
                Jedi oldJedi = (Jedi)character;
                oldJedi.Affiliation = jedi.Affiliation;
                oldJedi.Bio = jedi.Bio;
                oldJedi.Force = jedi.Force;
                oldJedi.Image = jedi.Image;
                oldJedi.Name = jedi.Name;
                oldJedi.Weapon = jedi.Weapon;
                oldJedi.Rank = jedi.Rank;
                oldJedi.LightSaber = jedi.LightSaber;
                oldJedi.Quote = jedi.Quote;
            }
            else
            {
                ///Hunter
            }
            return RedirectToAction("Details", new { id = jedi.ID });
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var target = characters.Where(x=>x.ID == id).FirstOrDefault();
            characters.Remove(target);

            return RedirectToAction("Index");
        }
    }
}