using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpireDirectory.Models
{
    public abstract class Character
    {
        protected static int NextId { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public Affiliation Affiliation { get; set; }
        public string Bio { get; set; }
        public string Weapon { get; set; }
        public string Quote { get; set; }
        public string Image { get; set; }

    }
}