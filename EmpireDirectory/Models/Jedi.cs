using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpireDirectory.Models
{
    public class Jedi : Character
    {        public Rank Rank { get; set; }
        public string LightSaber { get; set; }
        public string Force { get; set; }
        public Jedi(string name, Affiliation affiliation, string bio, string weapon, string quote, string image, Rank rank, string lightsaber, string force)
        {
            ID = NextId++;
            Name = name;
            Affiliation = affiliation;
            Bio = bio;
            Weapon = weapon;
            Quote = quote;
            Image = image;
            Rank = rank;
            LightSaber = lightsaber;
            Force = force;
        }
        public Jedi()
        {

        }
    }
}