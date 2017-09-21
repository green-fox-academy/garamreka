using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            Counter(10);
            Console.ReadLine();
        }
        public static void Counter (int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n);
                Counter(n-1);
            }
        }
    }
}
