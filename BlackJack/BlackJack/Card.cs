

using System.Drawing;

namespace BlackJack
{
    class Card
    {
        public Enums.Suit Suit;
        public Enums.Value Value;
        bool faceDown; 
        public Card NextCard
        {
            get
            {
                return new Card(Suit, Value++);
            }
        }

        public Card PrevCard
        {
            get
            {
                return new Card(Suit, Value--);
            }
        }

        public Enums.Value PrevValue
        {
            get
            {
                return Value--;
            }
        }
        public Enums.Value NextValue
        {
            get
            {
                return Value++;   
            }
        }


        public Card(Enums.Suit suit, Enums.Value value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}s";
        }
    }
}
