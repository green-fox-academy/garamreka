using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringedInstruments
{
    public abstract class StringedInstrument : Instrument
    {
        public int numberOfStrings;

        public abstract string Sound();
    }
}
