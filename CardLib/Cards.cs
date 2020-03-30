/* Cards.cs  - Defines the Cards class
 * 
 * Author: Sterling Wenzelbach
 * Since: 2020-02-03, edited: 2020-02-09, now supports generic collection
 * 
 * Source: 
            Beginning Visual C# 2012 Programming
            Chapter 11 - Collections, Comparisons, and Conversions
            Wrox Press © 2013

 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Cards : List<Card>, ICloneable
    {
        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        public void CopyTo(Cards targetCards)
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
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }
       
    }
}
