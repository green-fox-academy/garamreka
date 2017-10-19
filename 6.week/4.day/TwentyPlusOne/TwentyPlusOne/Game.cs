using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        static Random random = new Random();
        static Card firstCard = Deck.PullRandom();
        static Card secondCard = Deck.PullRandom();
        static int opponentScore = 0;
        static int playerScore = 0;
        static Card pulledCard;
        static bool isGameEnded = false;

        public static void Play()
        {
            Console.WriteLine("Welcome. Press any key to start the game");
            Console.ReadKey();
            opponentScore = OpponentScore();
            Deck.NewDeck();
            Deck.ShuffleDeck();

            Console.WriteLine($"You have a \n" +
                $"{firstCard.ColorOfCard} {firstCard.SuitOfCard} {firstCard.RankOfCard} and a \n" +
                $"{secondCard.ColorOfCard} {secondCard.SuitOfCard} {secondCard.RankOfCard}");

            playerScore = JQKequalsTen(firstCard) + JQKequalsTen(secondCard);

            CountinueOrStop();

            do
            {
                string countinuePlaying = Console.ReadLine();

                if (countinuePlaying == "yes")
                {
                    Console.WriteLine("Pull a card. first/last/random");
                    string userInput = Console.ReadLine();

                    PullCard(userInput);

                    playerScore += JQKequalsTen(pulledCard);
                    
                    CountinueOrStop();
                }
                if (countinuePlaying == "no")
                {
                    IsScoreMoreThanTwentyone();
                    OpponentHasMoreScore();
                    IsGameWon();
                }
            } while (!isGameEnded);
        }

        public static int OpponentScore()
        {
            return random.Next(15, 22);
        }

        public static int JQKequalsTen(Card input)
        {
            int value = 0;

            if (input.RankOfCard == Card.Rank.Jack || input.RankOfCard == Card.Rank.Queen || input.RankOfCard == Card.Rank.King)
            {
                value = 10;
            }
            else
            {
                value = (int)input.RankOfCard;
            }

            return value;
        }

        public static void CountinueOrStop()
        {
            Console.WriteLine($"Your score is {playerScore}. The opponent's score is {opponentScore}");
            IsScoreMoreThanTwentyone();
            if (!isGameEnded)
            {
                Console.WriteLine("Would you like to countinue? yes/no");
            }
        }

        public static void PullCard(string userInput)
        {
            if (userInput == "first")
            {
                pulledCard = Deck.PullFirst();
            }
            else if (userInput == "last")
            {
                pulledCard = Deck.PullLast();
            }
            else if (userInput == "random")
            {
                pulledCard = Deck.PullRandom();
            }

            Console.WriteLine($"{pulledCard.ColorOfCard} {pulledCard.SuitOfCard} {pulledCard.RankOfCard}");
        }

        public static void IsScoreMoreThanTwentyone()
        {
            if (playerScore > 21)
            {
                isGameEnded = true;
                Console.WriteLine("You lost.");
            }
        }

        public static void OpponentHasMoreScore()
        {
            if (playerScore < opponentScore)
            {
                isGameEnded = true;
                Console.WriteLine("You lost.");
            }
        }

        public static void IsGameWon()
        {
            if (playerScore <= 21 && playerScore >= opponentScore)
            {
                isGameEnded = true;
                Console.WriteLine("You won! Congrats!");
            }
        }
    }
}
