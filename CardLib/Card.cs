using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// a card class
    /// </summary>
    public class Card : IComparable
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
        public Card()
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

        public int GetRank()
        {
            return (int)rank;
        }

        public override int GetHashCode()
        {

            int rank = GetRank();
            
            int hashCode = rank * 1234;

            return hashCode;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">The object the current instance is being compared to.</param>
        /// <returns>An integer indicating whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.</returns>
        public int CompareTo(object card)
        {
            //if the parameter object is comparable to a CP
            if (card is Card)
            {
                //return the difference between 
                return this.GetHashCode() - card.GetHashCode();
            }
            else
            {
                throw (new ArgumentException("Cannot compare Card objects with of type: " + card.GetType().ToString() + "."));
            }

        }
    }
}
