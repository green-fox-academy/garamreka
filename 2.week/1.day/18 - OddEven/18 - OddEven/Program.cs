using System;

namespace _18___OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write a number: ");
            int num = Int32.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine("Odd");
            } else
            {
                Console.WriteLine("Even");
            }
            Console.ReadLine();
        }
    }
}
