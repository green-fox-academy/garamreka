using System;
using System.Collections.Generic;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unique = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };

            RemoveDuplicates(unique);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void RemoveDuplicates(List<int> input)
        {
            var output = new List<int> { };
            bool isDuplicate = false;

            for (int i = 0; i < input.Count; i++)
            {
                isDuplicate = false;
                for (int j = 0; j < output.Count; j++)
                {
                    if (input[i] == output[j])
                    {
                        isDuplicate = true;
                    }
                }
                if (isDuplicate == false)
                {
                    output.Add(input[i]);
                }
            }
            foreach (var element in output)
            {
                Console.Write(element + " ");
            }
        }
    }
}
