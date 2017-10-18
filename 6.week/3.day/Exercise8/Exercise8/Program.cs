using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!
            string example = "AnagraM";

            foreach (var character in FindUppercaseWithQuery(example))
            {
                Console.Write($"{character} ");
            }
            Console.WriteLine();

            foreach (var character in FindUppercaseWithLambda(example))
            {
                Console.Write($"{character} ");
            }
            Console.ReadLine();
        }

        static List<char> FindUppercaseWithQuery(string input)
        {
            var uppercase =
                (from character in input
                where Char.IsUpper(character)
                select character).ToList();
            return uppercase;
        }

        static List<char> FindUppercaseWithLambda(string input)
        {
            var uppercase = input.Where(character => Char.IsUpper(character)).ToList();
            return uppercase;
        }
    }
}
