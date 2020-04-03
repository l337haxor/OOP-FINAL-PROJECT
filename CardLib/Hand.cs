using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLib
{
    public class Hand : List<Card>, IEnumerable, ICloneable
    {
        protected int maximumHandSize = 6;

        public virtual int MaxHandSize
        {
            get { return maximumHandSize; }
            
        }
        /// <summary>
        /// 
        /// </summary>
        public Hand()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hand"></param>
        /// <param name="cribCard"></param>
        public Hand(Hand Hand, Card cribCard)
        {

        }
     
        /// <summary>
        /// Custom Add() method to sort the hand whenever a new card is added.
        /// </summary>
        /// <param name="card"></param>
        public new void Add(Card card)
        {
            //if adding the card exceeds the hand size limit
            if (this.Count >= this.MaxHandSize)
            {
                //throw new IndexOutOfRangeException("Hand size cannot exceed " + this.MaxHandSize + " cards!");
            }
            else
            {
                //Call base Add() method
                base.Add(card);
                //To keep sorted
                Sort();
            }
        }
        /// <summary>
        /// Loops through the cards in a hand and displays them
        /// </summary>
        public void DisplayHand()
        {
            foreach(object card in this)
            {
               Console.WriteLine(card.ToString());
            }
        }
        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        public void CopyTo(Hand targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }
        /// <summary>
        /// Clones a list of cards
        /// </summary>
        /// <returns>a list of cards</returns>
        public object Clone()
        {
            Hand newCards = new Hand();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }
    }
}
