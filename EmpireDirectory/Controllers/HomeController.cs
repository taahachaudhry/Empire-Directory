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
        List<Character> characters = new List<Character>()
        {
            new Jedi("Luke Skywalker",Affiliation.Rebel,"A skywalker kind of guy.","Light Saber","NoOoOoOo!!","http://img2.wikia.nocookie.net/__cb20091030151422/starwars/images/thumb/d/d9/Luke-rotjpromo.jpg/250px-Lukerotjpromo.jpg",Rank.MasterJedi,"Green","Yes"),
            new Jedi("Mace Windu",Affiliation.Rebel,"The baddest JEDI there is aka SLJ","Light Saber","I got the force MF!","http://img1.wikia.nocookie.net/__cb20071230055326/starwars/images/thumb/f/fc/Mace_Windu.jpg/250px-Mace_Windu.webp",Rank.JediCounsel,"Purple","Yes"),
            new Jedi("Darth Vader",Affiliation.Empire,"It's complicated...","Light Saber","Luke, I am your father!","http://www.starwars7news.com/wp-content/uploads/2014/08/darth-vader.jpg",Rank.MasterJedi,"Red","Yes"),
            new BountyHunter("Tulkh",Affiliation.Mersernary,"Tulkh was a male Whiphid bounty hunter who was employed by the resurgent Sith Empire during the Cold War. Tulkh was one of the many bounty hunters who was hired to hunt down and find the Murakami orchid.","Club","Get in my belly","http://img3.wikia.nocookie.net/__cb20120920173350/starwars/images/thumb/7/7a/Tulkh.jpg/250px-Tulkh.jpg",new List<string>(){"Thing 1","Thing 2", "Thing 3"},1),
            new BountyHunter("Boba Fett",Affiliation.Mersernary,"Boba Fett was a Mandalorian warrior and bounty hunter. He was a clone of the famed Jango Fett, created in 32 BBY as the first of many Fett replicas designed to become part of the Grand Army of the Republic.","Big Pistol","He's no good to me dead!","http://img4.wikia.nocookie.net/__cb20130920001614/starwars/images/thumb/5/58/BobaFettMain2.jpg/250px-BobaFettMain2.webp",new List<string>{"Unlucky Guy 1","Who 2", "Dead 3"},6)
            
        };
        public ActionResult Index()
        {
            int RandomNum = new Random().Next(characters.Count());
            HomeIndexVM bucket = new HomeIndexVM();
            bucket.Characters = characters;
            bucket.FeauturedCharacter = bucket.Characters[RandomNum];
            return View(bucket);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}