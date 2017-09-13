using System;

namespace _28___DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int num = int.Parse(Console.ReadLine());
            string star = "";

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
            Console.ReadLine();
        }
    }
}
