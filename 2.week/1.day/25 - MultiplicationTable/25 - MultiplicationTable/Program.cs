using System;

namespace _25___MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write a number: ");
            int num = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + num + " = " + (i * num));
            }
            Console.ReadLine();
        }
    }
}
