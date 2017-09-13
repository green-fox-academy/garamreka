using System;

namespace _33___GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wanna play? Find out my number. It's between 1 and 10. ");
            int guess;
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 11);

            do
            {
                Console.WriteLine("Enter your guess.");
                guess = int.Parse(Console.ReadLine());

                if (guess > rndNum)
                {
                    Console.WriteLine("My number is lower.");
                }
                else if (guess < rndNum)
                {
                    Console.WriteLine("My number is higher.");
                }
            }
            while (guess != rndNum); {
                Console.WriteLine("Correct! You won!");
            }
    
            Console.ReadLine();
        }
    }
}
