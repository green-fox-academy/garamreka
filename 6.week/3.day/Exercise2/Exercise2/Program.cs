using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };


            Console.WriteLine(AverageOfOddWithQuery(n));
            Console.WriteLine(AverageOfOddWithLambda(n));
            Console.ReadLine();
        }

        static double AverageOfOddWithQuery (int[] n)
        {
            IEnumerable<int> oddAverage =
                from number in n
                where number % 2 != 0
                select number;

            return oddAverage.Average();
        }

        static double AverageOfOddWithLambda(int[] n)
        {
            double oddAverage = n.Where(number => number % 2 != 0).Average();
            return oddAverage;
        }
    }
}
