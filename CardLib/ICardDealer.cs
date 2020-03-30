/* ICardDealer.cs  - Defines the ICardDealer class
 * 
 * Author: Sterling Wenzelbach
 * Since: 2020-03-07
 * 
 * Source: 
          
 */
using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public interface ICardDealer
    {
        /// <summary>
        /// Shuffles the deck
        /// </summary>
        void Shuffle();

        /// <summary>
        /// Deals a card
        /// </summary>
        /// <returns>a card</returns>
        Card DealTopCard();

        ////
    }
}
