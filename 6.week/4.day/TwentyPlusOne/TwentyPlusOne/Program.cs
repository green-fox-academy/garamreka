using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck.CreateDeck();
            Deck.ShuffleDeck();

            foreach (Card card in Deck.cards)
            {
                Console.WriteLine($"{card.SuitOfCard} {card.RankOfCard}");
            }
            
            Console.ReadLine();
        }
    }
}
