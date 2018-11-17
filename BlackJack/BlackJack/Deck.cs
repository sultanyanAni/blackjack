using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck: Stack<Card>
    {
        public Dictionary<Card, Image> deckImages;
        public Deck()
        {
            deckImages = new Dictionary<Card, Image>();
            ReloadDeck();
        }

        public void Shuffle(int timesToShuffle)
        {

            List<Card> deckToShuffle = new List<Card>();
            for (int i = 0; i < ItemCount; i++)
            {
                deckToShuffle.Add(Pop());
            }
            Random ran = new Random();
            int firstIndex = 0;
            int secondIndex = 0;
            Card temp;
            for (int f = 0; f < timesToShuffle; f++)
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < deckToShuffle.Count; j++)
                    {
                        firstIndex = ran.Next(0, deckToShuffle.Count);
                        while (secondIndex == firstIndex)
                        {
                            secondIndex = ran.Next(0, deckToShuffle.Count);
                        }
                        temp = deckToShuffle[firstIndex];
                        deckToShuffle[firstIndex] = deckToShuffle[secondIndex];
                        deckToShuffle[secondIndex] = temp;
                    }
                }
            }

            for (int i = 0; i < deckToShuffle.Count; i++)
            {
                Push(deckToShuffle[i]);
            }

        }
        public Card Draw()
        {
            return Pop();
        }
        public void ReloadDeck()
        {
            for (int i = 0; i < ItemCount; i++)
            {
                Pop();
            }
            for (int i = 0; i < 4; i++)
            {
                Image imageToAdd = Properties.Resources.King_of_Hearts;
                Card cardToAdd;
                for (int x = 1; x < 14; x++)
                {
                    cardToAdd = new Card((Enums.Suit)i, (Enums.Value)x);
                    Push(cardToAdd);
                   
                    switch (cardToAdd.Value)
                    {
                        case Enums.Value.Ace:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources.Ace_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources.Ace_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources.Ace_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources.Ace_of_Spades;
                                    break;
                            }
                            break;

                        case Enums.Value.Two:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._2_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._2_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._2_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._2_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Three:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._3_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._3_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._3_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._3_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Four:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._4_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._4_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._4_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._4_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Five:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._5_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._5_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._5_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._5_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Six:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._6_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._6_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._6_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._6_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Seven:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._7_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._7_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._7_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._7_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Eight:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._8_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._8_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._8_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._8_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Nine:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._9_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._9_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._9_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._9_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Ten:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources._10_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources._10_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources._10_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources._10_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Jack:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources.Jack_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources.Jack_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources.Jack_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources.Jack_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.Queen:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources.Queen_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources.Queen_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources.Queen_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources.Queen_of_Spades;
                                    break;
                            }
                            break;
                        case Enums.Value.King:
                            switch (cardToAdd.Suit)
                            {
                                case Enums.Suit.Club:
                                    imageToAdd = Properties.Resources.King_of_Clubs;
                                    break;
                                case Enums.Suit.Diamond:
                                    imageToAdd = Properties.Resources.King_of_Diamonds;
                                    break;
                                case Enums.Suit.Heart:
                                    imageToAdd = Properties.Resources.King_of_Hearts;
                                    break;
                                case Enums.Suit.Spade:
                                    imageToAdd = Properties.Resources.King_of_Spades;
                                    break;
                            }
                            break;

                    }

                    deckImages.Add(cardToAdd, imageToAdd);
                }
            }
        }
    }
}
