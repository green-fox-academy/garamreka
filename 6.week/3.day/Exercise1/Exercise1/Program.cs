using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            foreach (var even in EvenNumbersWithQuery(n))
            {
                Console.Write($"{even} ");
            }
            Console.WriteLine();
            foreach (var even in EvenNumbersWithLambda(n))
            {
                Console.Write($"{even} ");
            }

            Console.ReadLine();
        }

        public static List<int> EvenNumbersWithQuery (int[] n)
        {
            IEnumerable<int> evens =
               from number in n
               where number % 2 == 0
               select number;

            return evens.ToList();
        }

        public static List<int> EvenNumbersWithLambda(int[] n)
        {
            IEnumerable<int> evens = n.Where(x => x % 2 == 0);

            return evens.ToList();
        }
    }
}
