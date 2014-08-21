using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpireDirectory.Models
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        List<Character> Characters {get; set;}
        static Singleton()
        {

        }
        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}