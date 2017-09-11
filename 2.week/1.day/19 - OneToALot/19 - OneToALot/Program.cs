using System;

namespace _19___OneToALot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Not enough");
            } else if (num == 1)
            {
                Console.WriteLine("One");
            } else if (num == 2)
            {
                Console.WriteLine("Two");
            } else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}
