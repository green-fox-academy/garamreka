using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Card
    {
        public string ColorOfCard { get; set; }
        public string SuitOfCard { get; set; }
        public string RankOfCard { get; set; }

        public Card(Suit suit, Rank rank)
        {
            SuitOfCard = suit.ToString();
            RankOfCard = rank.ToString();
        }

        public enum Color
        {
            Red,
            Black
        }

        public enum Suit
        {
            Club,
            Diamond,
            Heart,
            Spade
        }

        public enum Rank
        {   
            Two, 
            Three, 
            Four, 
            Five, 
            Six, 
            Seven, 
            Eight, 
            Nine, 
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
    }
}
