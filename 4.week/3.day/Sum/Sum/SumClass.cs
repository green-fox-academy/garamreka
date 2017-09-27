using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class SumClass
    {
        public int SumElementsOfList(List<int> intList)
        {
            int sumOfElements = 0;

            foreach (var element in intList)
            {
                sumOfElements += element;
            }

            return sumOfElements;
        }
    }
}
