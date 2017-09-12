using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            double number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial is " + Factorio(number));
            Console.ReadLine();
        }

        public static double Factorio (double num)
        {
            double result = 1;
            for (var i = num; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
