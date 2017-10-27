using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public Food Food { get; set; }
        public Drink Drink { get; set; }
        public Trick Trick { get; set; }
        public List<Trick> Tricks { get; set; }
        public int TrickCount;

        public Fox()
        {
            Tricks = new List<Trick>();
            TrickCount = Tricks.Count;
        }
    }
}
