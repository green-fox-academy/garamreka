using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            foreach (var squared in SquareMoreThanTwentyWithQuery(n))
            {
                Console.Write($"{squared} ");
            }
            Console.WriteLine();

            foreach (var squared in SquareMoreThanTwentyWithLambda(n))
            {
                Console.Write($"{squared} ");
            }
            Console.ReadLine();
        }

        static List<int> SquareMoreThanTwentyWithQuery(int[] n)
        {
            IEnumerable<int> squareMoreThanTwenty =
                from number in n
                where number * number > 20
                select number;
            return squareMoreThanTwenty.ToList();
        }

        static List<int> SquareMoreThanTwentyWithLambda(int[] n)
        {
            List<int> squareMoreThanTwenty = n.Where(number => number * number > 20).ToList();
            return squareMoreThanTwenty;
        }
    }
}
