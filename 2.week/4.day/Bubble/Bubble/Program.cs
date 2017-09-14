using System;
using System.Collections.Generic;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 34, 12, 24, 9, 5 };

            Sort(list, false);

            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Sort(List<int> input, bool boolean)
        {
            ForLoop(input);
            Descend(input, boolean);
        }
        public static void ForLoop (List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, (j + 1));
                    }
                }

            }
        }
        public static void Swap (List<int> input, int m, int n) 
        {
            int temp = input[m];
            input[m] = input[n];
            input[n] = temp;
        }
        public static void Descend (List<int> input, bool boolean)
        {
            if (boolean == true)
            {
                for (int k = input.Count - 1; k >= 0; k--)
                {
                    Console.Write(input[k] + " ");
                }
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
