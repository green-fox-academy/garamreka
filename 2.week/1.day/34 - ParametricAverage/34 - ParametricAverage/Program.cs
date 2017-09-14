using System;

namespace _34___ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi! Give me a number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                Console.Write("Give one more! ");
                sum += int.Parse(Console.ReadLine());
            }

            double average = sum / num;
            Console.WriteLine("Sum: " + sum + ", Average: " + average);
            Console.ReadLine();
        }
    }
}
