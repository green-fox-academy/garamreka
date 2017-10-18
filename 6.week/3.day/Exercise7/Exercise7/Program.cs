using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            foreach (var city in FindAIWithQuery(cities))
            {
                Console.WriteLine(city);
            }

            foreach (var city in FindAIWithLambda(cities))
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }

        static List<string> FindAIWithQuery(string[] input)
        {
            var city =
                (from c in input
                where c.StartsWith("A") && c.EndsWith("I")
                select c).ToList();

            return city;
        }

        static List<string> FindAIWithLambda(string[] input)
        {
            var city = input.Where(c => c.StartsWith("A") && c.EndsWith("I")).ToList();

            return city;
        }
    }
}
