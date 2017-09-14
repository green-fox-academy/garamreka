using System;

namespace _35___DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChessTable");
            Console.WriteLine();
            int n = 8;
            for (int i = 1; i <= n; i++)
            {
                if (i%2 == 1)
                {
                    for (int j = 1; j <= n/2; j++)
                    {
                        Console.Write("% ");
                    }
                    Console.WriteLine();
                }
                else 
                {
                    for (int k = 1; k <= n/2; k++)
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
