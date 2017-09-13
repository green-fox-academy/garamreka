using System;

namespace _05___Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Reversed(reversed);
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Reversed(string input)
        {
            char[] chars = input.ToCharArray();

            for (var i = chars.Length-1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }
            
        }
    }
}
