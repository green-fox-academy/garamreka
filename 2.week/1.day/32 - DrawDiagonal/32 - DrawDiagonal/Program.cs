using System;

namespace _32___DrawDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the height of your square ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Here is your square with a diagonal line!");

            for (int i = 0; i < height; i++)
            {
                Console.Write("%");
            }

            int counter = 0;

            Console.WriteLine();
            for (int j = 0; j < height - 2; j++)
            {
                    Console.Write("%");
                    for (int k = 0; k < height - 2; k++)
                    {
                        if ( k == counter)
                        {
                        Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    counter++;
                    Console.Write("%");
                    Console.WriteLine();
                }
            for (int i = 0; i < height; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
