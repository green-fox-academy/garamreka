using System;
using System.Collections;
using System.Collections.Generic;

namespace _12___QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

            Swap(list, 2, 5);

            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
            
            Console.ReadLine();
        }
        public static void Swap(IList list, int indexA, int indexB)
        {
            var tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
