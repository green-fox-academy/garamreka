using System;

namespace Printer
{
    class Program
    {

        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...

            string[] example1 = { "first" };
            string[] example2 = { "first", "second" };
            string[] example3 = { "first", "second", "third", "fourh" };

            Printer(example3);
            Console.ReadLine();
        }

        public static void Printer(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

        }
    }
}
