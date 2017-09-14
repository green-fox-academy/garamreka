using System;

namespace _30___DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the height of your diamond ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Here is your diamond!");
            Console.WriteLine();

            for (int i = 1; i <= (height - (height/2)); i++)
            {
                for (int j = 0; j < (height - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            if (height%2 == 0)
            {
                for (int i = ((height) - (height / 2)); i >= 1; i--)
                {
                    for (int j = 0; j < (height - i); j++)
                        Console.Write(" ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    for (int k = 1; k < i; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            else if (height % 2 == 1)
            {
                for (int i = ((height-1) - (height / 2)); i >= 1; i--)
                {
                    for (int j = 0; j < (height - i); j++)
                        Console.Write(" ");
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    for (int k = 1; k < i; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
