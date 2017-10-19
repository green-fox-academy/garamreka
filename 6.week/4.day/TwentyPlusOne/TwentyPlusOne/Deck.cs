using System;
using System.Collections.Generic;

namespace TwentyPlusOne
{
    class Deck
    {
        public static List<Card> cards = NewDeck();
        public static Random random = new Random();

        public static List<Card> NewDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (Card.Color color in Enum.GetValues(typeof(Card.Color)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                    {
                        deck.Add(new Card(color, suit, rank));
                    }
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
                var randomCard = cards[random.Next(0, cards.Count)];
                if (!temporaryCards.Contains(randomCard))
                {
                    temporaryCards.Add(randomCard);
                }
            }
            while (!(temporaryCards.Count == cards.Count));

            cards = temporaryCards;
        }

        public static Card PullFirst()
        {
            var firstCard = cards[0];
            cards.Remove(firstCard);
            return firstCard;
        }

        public static Card PullLast()
        {
            var lastCard = cards[cards.Count - 1];
            cards.Remove(lastCard);
            return lastCard;
        }

        public static Card PullRandom()
        {
            var randomCard = cards[random.Next(0, cards.Count)];
            cards.Remove(randomCard);
            return randomCard;
        }
    }
}
