using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
            
            Console.WriteLine(Sumdigit(23456));
            Console.ReadLine();
        }
        public static int Sumdigit (int n)
        {
            int divide = (n / 10);

            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + Sumdigit(divide);
            }
        }
    }
}
