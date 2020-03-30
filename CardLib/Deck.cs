using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    /// <summary>
    /// a deck of cards class
    /// </summary>
    public class Deck : ICardDealer
    {
        /// <summary>
        /// Nondefault constructor. Allows aces to be set high.
        /// </summary>
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        /// <summary>
        /// Nondefault constructor. Allows a trump suit to be used.
        /// </summary>
        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }
        /// <summary>
        /// Nondefault constructor. Allows aces to be set high and a trump suit
        /// to be used.
        /// </summary>
        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        //Create a new array of cards
        private Cards cards = new Cards();

        /// <summary>
        /// Default Constructor - Creates 52 unique cards and adds them to cards list
        /// </summary>
        public Deck()
        {
            // 
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler LastCardDrawn;

        /// <summary>
        /// Gets a card
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns>a card</returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                    LastCardDrawn(this, EventArgs.Empty);

                return cards[cardNum];
            }
            else
                //throw the new exception
                throw new CardOutOfRangeException(cards.Clone() as Cards);
        }
        /// <summary>
        /// Deals the top card
        /// </summary>
        /// <returns>a card</returns>
        public Card DealTopCard()
        {
            if (cards.Count > 0)
            {
                Card card = cards[0];
                cards.Remove(card);

                return card;

            }
            else
            {
                //throw the new exception
                throw new CardOutOfRangeException(cards.Clone() as Cards);
            }
        }
        /// <summary>
        /// Deals a random card
        /// </summary>
        /// <returns>a card</returns>
        public Card DealRandomCard()
        {
            Random sourceGen = new Random();
            int sourceCard = 0;
            sourceCard = sourceGen.Next(0, cards.Count);
            Card card = cards[sourceCard];

            if (cards.Count > 0)
            {
                if (sourceCard < cards.Count)
                {
                    
                    cards.Remove(card);
                    sourceCard = sourceGen.Next(0, cards.Count);

                }
                else
                {
                    DealRandomCard();
                }
                return card;
            }
            else
            {
                //throw the new exception
                throw new CardOutOfRangeException(cards.Clone() as Cards);
            }

        }

        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            //copies cards into the source instance
            newDeck.CopyTo(cards);
            Console.WriteLine(cards);
        }
        /// <summary>
        /// The number of cards remaining in the deck
        /// </summary>
        /// <returns>a number</returns>
        public int CardsRemaining()
        {
            return cards.Count;
        }
    }
}

