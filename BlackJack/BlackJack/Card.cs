

using System.Drawing;

namespace BlackJack
{ 
    class Card
    {
        public Enums.Suit Suit;
        public Enums.Value Value;
        

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
