using System;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named is anagram following your current language's style guide. 
            //It should take two strings and return a boolean value depending on whether its an anagram or not.

            Console.Write("Hi! Give me the two word that needs to be checked! ");
            string[] userInput = Console.ReadLine().Split();
            Console.WriteLine();

            IsAnagram(userInput[0], userInput[1]);
            Console.ReadLine();
        }
        public static void IsAnagram (string input1, string input2)
        {
            for (int i = input1.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i] == input2[j])
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                    break;
                }
                break;
            }
        }
    }
}
