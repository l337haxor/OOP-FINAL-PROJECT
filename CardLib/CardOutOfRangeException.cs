/* CardOutOfRangeException.cs  - Defines the CardOutOfRangeException class
 * 
 * Author: Sterling Wenzelbach
 * Since: 2020-02-03, edited: 2020-02-09
 * 
 * Source: 
            Beginning Visual C# 2012 Programming
            Chapter 13 - 
            Wrox Press © 2013

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    /// <summary>
    /// Invalid deck size error
    /// </summary>
    public class CardOutOfRangeException : Exception
    {
        //a seperate deck for error purposes
        private Cards deckContents;

        //get only property for the deck
        public Cards DeckContents
        {
            get
            {
                return deckContents;
            }
        }

        public CardOutOfRangeException(Cards sourceDeckContents)
           : base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }
    }
}