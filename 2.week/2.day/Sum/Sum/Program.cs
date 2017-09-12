using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4));
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
