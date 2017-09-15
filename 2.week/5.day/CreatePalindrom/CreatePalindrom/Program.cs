using System;

namespace CreatePalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named create palindrome following your current language's style guide. 
            //It should take a string, create a palindrome from it and then return it.
            Console.WriteLine("-- Palindromizer --");
            Console.WriteLine();
            Console.Write("Input: ");
            string userInput = Console.ReadLine();

            CreatePalindrom(userInput);
            Console.ReadLine();
        }
        public static void CreatePalindrom (string data)
        {
            string reverseData = "";

            for (int i = data.Length - 1; i >= 0; i--)
            {
                reverseData += data[i];
            }

            Console.WriteLine("Output: " + (data + reverseData));
        }
    }
}
