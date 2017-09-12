using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorio(5));
            Console.ReadLine();
        }

        public static int Factorio (int num)
        {
            int result = 1;
            for (var i = num; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
