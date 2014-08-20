using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpireDirectory.Models
{
    public class HomeIndexVM
    {
        public Character FeauturedCharacter { get; set; }
        public List<Character> Characters { get; set; }
    }
}