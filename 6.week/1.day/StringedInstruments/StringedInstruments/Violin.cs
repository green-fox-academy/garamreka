using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            numberOfStrings = 4;
        }

        public override string Sound()
        {
            return "Screech";
        }

        public override string Play()
        {
            return $"Violin, a {numberOfStrings}-stringed instrument that {Sound().ToLower()}s.";
        }
    }
}
