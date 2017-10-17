using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringedInstruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
        }

        public ElectricGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public override string Sound ()
        {
            return "Twang";
        }

        public override string Play ()
        {
            return $"Electric Guitar, a {numberOfStrings}-stringed instrument that {Sound().ToLower()}s.";
        }
    }
}
