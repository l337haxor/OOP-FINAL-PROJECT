using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    /// <summary>
    /// a deck of cards class
    /// </summary>
    public class Deck
    {
        //initialize an array of card objects
        private Card[] cards;

        /// <summary>
        /// Constructor for a deck, (array of cards)
        /// </summary>
        public Deck()
        {
            //create a card array of 52 cards
            cards = new Card[52];

            /// <summary>
            /// Create the deck of 52 unique cards
            /// </summary>
            //loop through the suits
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                //loop through the ranks
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //create a card
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                                                                (Rank)rankVal);
                }
            }
        }
        /// <summary>
        /// Returns a card
        /// </summary>
        /// <param name="cardNum">1-52</param>
        /// <returns></returns>
        public Card GetCard(int cardNum)
        {
            //if valid
            if (cardNum >= 0 && cardNum <= 51)
                //return the card
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                          "Value must be between 0 and 51."));
        }
        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            //create an array of 52 cards
            Card[] newDeck = new Card[52];
            //create an array of booleans 
            bool[] assigned = new bool[52];
            // respresents a psuedo-random number
            Random sourceGen = new Random();

            //loop through the deck
            for (int i = 0; i < 52; i++)
            {
                // reset to 0
                int destCard = 0;
                // reset to false
                bool foundCard = false;
                //loop till a valid card is found
                while (foundCard == false)
                {
                    //sets to a number (0-51)
                    destCard = sourceGen.Next(52);
                    //
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                //card at value is 'found'
                assigned[destCard] = true;
                //record the card
                newDeck[destCard] = cards[i];
            }
            // copies each of the cards in newDeck back into cards
            //Insures that the same set of cards is being used (memory related)
            newDeck.CopyTo(cards, 0);
        }
    }
}

