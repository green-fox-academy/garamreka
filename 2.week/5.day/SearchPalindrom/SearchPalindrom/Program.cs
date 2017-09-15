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

            SearchPalindrom(userInput);

            Console.ReadLine();
        }

        public static void SearchPalindrom (string input)
        {
            var output = new List<string> { };
            char[] inputCharacters = input.ToCharArray();
            string palindromCharacters = string.Empty;
            int counter = 1;

            Array.Reverse(inputCharacters);
            string reverseInput = new string(inputCharacters);
            if (input == reverseInput)
            {
                output.Add(input);
            }

            for (var i = 1; i < inputCharacters.Length - 1; i++)
            {
                if (inputCharacters[i - counter] == inputCharacters[i + counter])
                {
                    palindromCharacters = inputCharacters[i - counter].ToString() + inputCharacters[i].ToString() + inputCharacters[i + counter].ToString();
                    output.Add(palindromCharacters);

                    if (inputCharacters[i - 2] == inputCharacters[i + 2])
                    {
                        palindromCharacters = inputCharacters[i - 2].ToString() + inputCharacters[i - 1].ToString() + inputCharacters[i].ToString() + inputCharacters[i + 1].ToString() + inputCharacters[i + 2].ToString();
                        output.Add(palindromCharacters);
                    }
                }
                if (inputCharacters[i] == inputCharacters[i + 1] && inputCharacters[i-1] == inputCharacters[i + 2])
                {
                    palindromCharacters = inputCharacters[i - 1].ToString() + inputCharacters[i].ToString() + inputCharacters[i + 1].ToString() + inputCharacters[i + 2].ToString();
                    output.Add(palindromCharacters);
                }
            }

            foreach (var element in output)
            {
                Console.WriteLine(element);
            }
        }

    }
}
