using System;

namespace _26___CountsFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Give me a second number: ");
            int n2 = Int32.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("The second number should be bigger");
            } else
            {
                for (var i = n1; i < n2; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
