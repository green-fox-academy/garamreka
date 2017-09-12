using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is " + Sum(sum));
            Console.ReadLine();
        }

        public static int Sum(int num)
        {
            int result = 0;
            for (var i = num; i > 0; i--)
            {
             result += i;
            }
            return result;
        }
    }
}
