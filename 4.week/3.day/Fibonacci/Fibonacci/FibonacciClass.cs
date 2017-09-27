using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciClass
    {
        public double ComputeFibonacci(double index)
        {
            //double elementByIndex = 0;
            int firstElement = 0;
            int secondElement = 1;
            
            if (index < 1)
            {
                return 400;
            }
            if (index == 1)
            {
                return firstElement;
            }
            if (index == 2)
            {
                return secondElement;
            }

            return ComputeFibonacci(index - 1) + ComputeFibonacci(index - 2);
        }
    }
}
