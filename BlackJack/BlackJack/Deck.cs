using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck : Stack<Card>
    {
        public Deck()
        {
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
                for (int x = 1; x < 14; x++)
                {
                    Push(new Card((Enums.Suit)i, (Enums.Value)x));
                }
            }
        }
    }
}
