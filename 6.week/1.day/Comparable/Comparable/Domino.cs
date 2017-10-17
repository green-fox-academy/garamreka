using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(Domino other)
        {
            if (this.GetValues()[0] == other.GetValues()[0])
            {
                this.GetValues()[1].CompareTo(other.GetValues()[1]);
            }
            return this.GetValues()[0].CompareTo(other.GetValues()[0]);
        }

        public override string ToString()
        {
            return $"[{this.GetValues()[0].ToString()},{this.GetValues()[1]}]";
        }
    }
}
