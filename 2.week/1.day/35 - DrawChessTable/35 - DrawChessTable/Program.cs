using System;

namespace _35___DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChessTable");
            Console.WriteLine();
            for (int i = 1; i <= 8; i++)
            {
                if (i%2 == 1)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write("% ");
                    }
                    Console.WriteLine();
                }
                else 
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        Console.Write(" %");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
