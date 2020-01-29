using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    /// <summary>
    /// a card class
    /// </summary>
    public class Card
    {
        // fixed values
        public readonly Suit suit;
        public readonly Rank rank;

        /// <summary>
        /// pctor
        /// </summary>
        /// <param name="newSuit">a suit</param>
        /// <param name="newRank">a rank</param>
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        /// <summary>
        /// dctor
        /// </summary>
        private Card()
        {
        }

        /// <summary>
        /// ToSting - card info
        /// </summary>
        /// <returns> a string displaying the card information + an "s" at the end</returns>
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
