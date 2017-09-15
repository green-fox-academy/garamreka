using System;
using System.Collections.Generic;

namespace SearchPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named search palindrome following your current language's style guide. 
            //It should take a string, search for palindromes that at least 3 characters long and 
            //return a list with the found palindromes.

            Console.WriteLine("Give me a word or sentence to check: ");
            string userInput = Console.ReadLine();
            var List = new List<string> { };

            SearchPalindrom(userInput, List);

            Console.ReadLine();
        }

        public static void SearchPalindrom(string input, List<string> output)
        {
            int counter = 3;
            int n = 2;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - n; j++)
                {
                    string subInput = input.Substring(j, counter);
                    char[] subInputCharacters = subInput.ToCharArray();
                    Array.Reverse(subInputCharacters);
                    string reverseSubInput = new string(subInputCharacters);

                    if (subInput == reverseSubInput)
                    {
                        output.Add(subInput);
                    }
                }
                
                counter++;
                n++;
            }

            foreach (var element in output)
            {
                Console.WriteLine(element);
            }
        }

    }
}
