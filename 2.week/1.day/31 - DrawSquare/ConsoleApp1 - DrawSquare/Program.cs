using System;

namespace ConsoleApp1___DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the height of your square ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Here is your square!");

                for (int j = 0; j < height; j++)
                {
                    Console.Write("%");
                }
                Console.WriteLine();
                for (int k = 0; k < height-2; k++)
                {
                    Console.Write("%");
                    for (int l = 0; l < height-2; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
                for (int j = 0; j < height; j++)
                {
                    Console.Write("%");
                }
                Console.WriteLine();

            Console.ReadLine();
        }
    }
}
