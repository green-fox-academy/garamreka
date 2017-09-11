using System;

namespace _17___AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please writre the first integer ");
            int first = Int32.Parse(Console.ReadLine());

            Console.Write("Please writre the second integer ");
            int second = Int32.Parse(Console.ReadLine());

            Console.Write("Please writre the third integer ");
            int third = Int32.Parse(Console.ReadLine());

            Console.Write("Please writre the fourth integer ");
            int fourth = Int32.Parse(Console.ReadLine());

            Console.Write("Please writre the fifth integer ");
            int fifth = Int32.Parse(Console.ReadLine());

            int sum = first + second + third + fourth + fifth;
            double average = (first + second + third + fourth + fifth) / 5;
            Console.WriteLine("Sum: " + sum + ", Average: " + average);
            Console.ReadLine();
        }
    }
}
