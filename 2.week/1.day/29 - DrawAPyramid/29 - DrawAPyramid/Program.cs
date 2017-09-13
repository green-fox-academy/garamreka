using System;

namespace _29___DrawAPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the height of your pyramid: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < num - i; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
