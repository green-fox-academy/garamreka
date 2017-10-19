using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Deck
    {
        public static List<Card> cards = CreateDeck();
        public static Random random = new Random();

        public static List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
            {
                foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                {
                    deck.Add(new Card(suit, rank));
                }
            }

            return deck;
        }

        public static void ShuffleDeck()
        {
            var temporaryCards = new List<Card>();
            int count = cards.Count;

            do
            {
                var randomCard = cards[random.Next(0, 52)];
                if (!temporaryCards.Contains(randomCard))
                {
                    temporaryCards.Add(randomCard);
                }
            }
            while (!(temporaryCards.Count == 52));

            cards = temporaryCards;
        }

        public void PullFirst()
        {

        }

        public void PullLast()
        {

        }

        public void PullRandom()
        {

        }
    }
}
