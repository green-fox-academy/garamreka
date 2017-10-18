using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!
            string example = "anagram";

            foreach (var pair in FrequencyWithQuery(example))
            {
                Console.Write($"{pair} ");
            }
            Console.WriteLine();

            foreach (var pair in FrequencyWithLambda(example))
            {
                Console.Write($"{pair} ");
            }
            Console.ReadLine();
        }

        static Dictionary<char, int> FrequencyWithQuery(string input)
        {
            var frequencyDictionary = (from character in input
                                       group character by character into groups
                                       select new { key = groups.Key, value = groups.Count() })
                        .ToDictionary(g => g.key, g => g.value);

            return frequencyDictionary;
        }

        static Dictionary<char, int> FrequencyWithLambda(string input)
        {
            var frequencyDictionary = input.GroupBy(character => character).ToDictionary(key => key.Key, value => value.Count());
            return frequencyDictionary;
        }
    }
}
