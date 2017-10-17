using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringedInstruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
        }

        public BassGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }

        public override string Play()
        {
            return $"Bass Guitar, a {numberOfStrings}-stringed instrument that {Sound().ToLower()}s.";
        }
    }
}
