using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] test = new char[] { 't', 'e', 's', 't'};

            Console.WriteLine(ConvertWithQuery(test));
            Console.WriteLine(ConvertWithLambda(test));
            Console.ReadLine();
        }

        static string ConvertWithQuery(char[] input)
        {
            var charToString = String.Concat(
                from character in input
                select character);
            return charToString;
        }

        static string ConvertWithLambda(char[] input)
        {
            var charToString = String.Concat(input.Select(character => character));
            return charToString;
        }
    }
}
