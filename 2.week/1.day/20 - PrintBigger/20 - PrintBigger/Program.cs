using System;

namespace _20___PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Give me a second number: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " is the bigger");
            }
            else if (n1 < n2)
            {
                Console.WriteLine(n2 + " is the bigger");
            }
            Console.ReadLine();
        }
    }
}
