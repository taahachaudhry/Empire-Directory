using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpireDirectory.Models
{
    public class BountyHunter : Character
    {
        public List<string> Targets { get; set; }
        public int Price { get; set; }

        public BountyHunter(string name, Affiliation affiliation, string bio, string weapon, string quote, string image, List<string> targets, int price)
        {
            ID = NextId++;
            Name = name;
            Affiliation = affiliation;
            Bio = bio;
            Weapon = weapon;
            Quote = quote;
            Image = image;
            Targets = targets;
            Price = price;
        }
        public BountyHunter()
        {

        }
    }
}