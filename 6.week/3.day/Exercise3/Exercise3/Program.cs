using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            foreach (var squared in SquareOfPositiveWithQuery(n))
            {
                Console.Write($"{squared} ");
            }
            Console.WriteLine();

            foreach (var squared in SquareOfPositiveWithQuery(n))
            {
                Console.Write($"{squared} ");
            }
            Console.ReadLine();
        }

        static List<int> SquareOfPositiveWithQuery (int[] n)
        {
            IEnumerable<int> squareOfPositive =
                from number in n
                where number > 0
                select number * number;
            return squareOfPositive.ToList();
        }

        static List<int> SquareOfPositiveWithLambda(int[] n)
        {
            List<int> squareOfPositive = n.Where(number => number > 0).Select(number => number * number).ToList();
            return squareOfPositive;
        }
    }
}
