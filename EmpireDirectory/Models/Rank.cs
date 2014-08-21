using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpireDirectory.Models
{
    public enum Rank
    {
        Padwan,
        Jedi,
        MasterJedi,
        JediCounsel
    }
    public static class Ranks
    {
        public static List<Rank> toList()
        {
            var list = new List<Rank>()
            {
                Rank.Padwan,
                Rank.Jedi,
                Rank.JediCounsel,
                Rank.MasterJedi
            };
            return list;
        }
    }
    
}
