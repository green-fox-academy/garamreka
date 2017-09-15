using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program where the program chooses a number between 1 and 100.
            //The player is then asked to enter a guess. If the player guesses wrong, 
            //then the program gives feedback and ask to enter an other guess until the guess is correct.

            //Make the range customizable(ask for it before starting the guessing).
            //You can add lives. (optional)

            Console.Write("I've a number between 1-10. ");
            int userGuess = 0;

            Random random = new Random();
            int randomNumber = random.Next(1, 10);

            LoopTheGame(userGuess, randomNumber);
            Console.ReadLine();
        }
        public static void LoopTheGame (int guess, int random)
        {
            Randomizer(randomNumber);

            do
            {
                Console.WriteLine("Enter your guess.");
                guess = int.Parse(Console.ReadLine());

                if (guess > random)
                {
                    Console.WriteLine("My number is lower.");
                }
                else if (guess < random)
                {
                    Console.WriteLine("My number is higher.");
                }
            }
            while (guess != random);
            {
                Console.WriteLine("Correct! You won!");
            }
        }
        public static void Randomizer (int data)
        {
            

        }
    }
}
