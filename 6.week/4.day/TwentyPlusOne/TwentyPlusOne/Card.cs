
namespace TwentyPlusOne
{
    class Card
    {
        public Color ColorOfCard { get; set; }
        public Suit SuitOfCard { get; set; }
        public Rank RankOfCard { get; set; }

        public Card(Color color, Suit suit, Rank rank)
        {
            ColorOfCard = color;
            SuitOfCard = suit;
            RankOfCard = rank;
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
            Two = 2, 
            Three = 3, 
            Four = 4, 
            Five = 5, 
            Six = 6, 
            Seven = 7, 
            Eight = 8, 
            Nine = 9, 
            Ten = 10,
            Ace = 11,
            Jack = 12,
            Queen = 13,
            King = 14,
            
        }
    }
}
