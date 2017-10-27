using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public List<string> Tricks { get; set; } = new List<string>() { "write HTML", "code in C#"};
        public int TrickCount { get; set; }

        public Fox()
        {
            this.Name = "Mr. Fox";
            this.Food = "pizza";
            this.Drink = "lemonade";
            this.TrickCount = Tricks.Count;
        }
    }
}
