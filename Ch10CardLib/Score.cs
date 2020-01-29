using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public static class Score
    {
        static int score;
        static int i = 0;

        /// <summary>
        /// Compares the rank of 2 cards and returns a true/false value.
        /// </summary>
        /// <param name="card1">a Card object</param>
        /// <param name="card2">a Card object</param>
        /// <returns>true/false</returns>
        private static bool CompareCardRanks(Card card1, Card card2)
        {
            bool value = false;

            if (card1.rank == card2.rank)
                value = true;

            return value;
        }

        /// <summary>
        /// Calculates the score for a Players hand with the Crib Card included.
        /// </summary>
        /// <param name="hand">A Players hand (4 cards)</param>
        /// <param name="cribCard">The Crib Card</param>
        /// <returns>an int (The calculated score)</returns>
        public static int Calculate(Card[] hand, Card cribCard)
        {
            foreach(Card card in hand)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine(cribCard.ToString());
            /////////////////////////////////////////////////////
            #region CHECK FOR DOUBLES

            if (CompareCardRanks(hand[i], hand[i+1]))
            {
                score += 2;
            }
            if (hand[i].rank == hand[i + 2].rank)
            {
                score += 2;
            }
            if (hand[i].rank == hand[i + 3].rank)
            {
                score += 2;
            }
            if (hand[i].rank == cribCard.rank)
            {
                score += 2;
            }
            //SECOND CARD
            if (hand[i+1].rank == hand[i + 2].rank)
            {
                score += 2;
            }
            if (hand[i+1].rank == hand[i + 3].rank)
            {
                score += 2;
            }
            if (hand[i+1].rank == cribCard.rank)
            {
                score += 2;
            }
            //THIRD CARD
            if (hand[i + 2].rank == hand[i + 3].rank)
            {
                score += 2;
            }
            if (hand[i + 2].rank == cribCard.rank)
            {
                score += 2;
            }
            //FOURTH CARD
            if (hand[i + 3].rank == cribCard.rank)
            {
                score += 2;
            }
            #endregion
            #region CHECK FOR 15's

            #endregion 
            #region CHECK FOR RUNs

            #endregion
            #region CHECK JACK

            #endregion 
            Console.WriteLine("\nPoints: " + score);
            return score;
        }
    }
}
