using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            foreach (var pair in FrequencyWithQuery(n))
            {
                Console.Write($"{pair} ");
            }
            Console.WriteLine();

            foreach (var pair in FrequencyWithLambda(n))
            {
                Console.Write($"{pair} ");
            }
            Console.ReadLine();
        }

        static Dictionary<int, int> FrequencyWithQuery(int[] n)
        {
            var frequencyDictionary = (from number in n
                        group number by number into groups
                        select new { key = groups.Key, value = groups.Count() })
                        .ToDictionary(g => g.key, g => g.value);

            return frequencyDictionary;
        }

        static Dictionary<int, int> FrequencyWithLambda(int[] n)
        {
            var frequencyDictionary = n.GroupBy(number => number).ToDictionary(key => key.Key, value => value.Count());
            return frequencyDictionary;
        }
    }
}
