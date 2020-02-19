using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Score
    {
        static int score;
        static int i = 0;

        public static void PointsAwarded(string message, int points)
        {
            Console.WriteLine("\n"+ message+ " " + points + " points!\n");
        }
        private static void CheckRuns(Hand hand)
        {
            //int count = 4;
            //hand.Sort(Rank);


            for (int count = 4; count > 0; count--)
            {
                //CHECK FOR 2 CARD RUN
                if ((int)hand[count - 1].rank == (int)hand[count].rank - 1 || (int)hand[count - 1].rank == (int)hand[count].rank + 1)
                {
                    //2 CARD RUN FOUND
                    if ((int)hand[count - 2].rank == (int)hand[count - 1].rank - 1 || (int)hand[count - 2].rank == (int)hand[count - 1].rank + 1)
                    {
                        //3 CARD RUN FOUND
                        PointsAwarded(hand[count] + "," + hand[count - 1] + "," + hand[count - 2] + " gave you a RUN OF 3 for", 3);
                        score += 3;

                        if ((int)hand[count - 3].rank == (int)hand[count - 2].rank - 1 || (int)hand[count - 3].rank == (int)hand[count - 2].rank + 1)
                        {
                            //4 CARD RUN FOUND
                            PointsAwarded(hand[count] + "," + hand[count - 1] + "," + hand[count - 2] + "," + hand[count - 3] + " gave you a RUN OF 4 for", 4);
                            score += 1;

                            if ((int)hand[count - 4].rank == (int)hand[count - 3].rank - 1 || (int)hand[count - 4].rank == (int)hand[count - 3].rank + 1)
                            {
                                //5 CARD RUN FOUND
                                PointsAwarded(hand[count] + "," + hand[count - 1] + "," + hand[count - 2] + "," + hand[count - 3] + "," + hand[count - 4] + " gave you a RUN OF 5 for", 5);
                                score += 1;
                            }
                        }
                    }
                }
                //Console.WriteLine(count);
                //Console.WriteLine(hand[count]);
                //hand.Remove(hand[count]);
            }
        }
                
                
        
        /// <summary>
        /// Adds the value of X amount of cards together to see if they add up to 15 
        /// </summary>
        /// <param name="card1">a Card object</param>
        /// <param name="card2">a Card object</param>
        /// <param name="card3">a Card object</param>
        /// <returns>a score (int)</returns>
        private static int FindFifthteens(Card card1, Card card2)
        {
            int score = 0;

            if((int)card1.rank + (int)card2.rank == 15)
            {
                score += 2;
                PointsAwarded(card1 + " and " + card2 + " gave you a 15 for", 2);
            }
            return score;
        }
        /// <summary>
        /// Adds the value of X amount of cards together to see if they add up to 15 
        /// </summary>
        /// <param name="card1">a Card object</param>
        /// <param name="card2">a Card object</param>
        /// <returns>a score (int)</returns>
        private static int FindFifthteens(Card card1, Card card2, Card card3)
        {
            int score = 0;

            if ((int)card1.rank + (int)card2.rank + (int)card3.rank == 15)
            {
                score += 2;
                PointsAwarded(card1 + " and " + card2 + " and " + card3 + " gave you a 15 for", 2);
            }
            return score;
        }
        /// <summary>
        /// Adds the value of X amount of cards together to see if they add up to 15 
        /// </summary>
        /// <param name="card1">a Card object</param>
        /// <param name="card2">a Card object</param>
        /// <param name="card3">a Card object</param>
        /// <param name="card4">a Card object</param>
        /// <returns>a score (int)</returns>
        private static int FindFifthteens(Card card1, Card card2, Card card3, Card card4)
        {
            int score = 0;

            if ((int)card1.rank + (int)card2.rank + (int)card3.rank + (int)card4.rank == 15)
            {
                score += 2;
                PointsAwarded(card1 + " and " + card2 + " and " + card3 + " and " + card4 + " gave you a 15 for", 2);
            }
            return score;
        }
        /// <summary>
        /// Adds the value of X amount of cards together to see if they add up to 15 
        /// </summary>
        /// <param name="card1">a Card object</param>
        /// <param name="card2">a Card object</param>
        /// <param name="card3">a Card object</param>
        /// <param name="card4">a Card object</param>
        /// <param name="cribCard"> The crib card</param>
        /// <returns>a score (int)</returns>
        private static int FindFifthteens(Card card1, Card card2, Card card3, Card card4, Card cribCard)
        {
            int score = 0;

            if ((int)card1.rank + (int)card2.rank + (int)card3.rank + (int)card4.rank + (int)cribCard.rank == 15)
            {
                score += 2;
                PointsAwarded(card1 + " and " + card2 + " and " + card3 + " and " + card4 + " and " + cribCard +" gave you a 15 for", 2);
            }
           
            return score;
        }
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
            {
                PointsAwarded(card1 + " and " + card2 + " gave you a pair for", 2);
                value = true;
            }

            return value;
        }
        /// <summary>
        /// Checks to see if a card is a Jack and its suit matches the Crib Card
        /// </summary>
        /// <param name="card">a Card object</param>
        /// <param name="cribCard">The Crib Card</param>
        /// <returns>true/false</returns>
        private static bool IsNobs(Card card, Card cribCard)
        {
            bool value = false;
            //If the card is a jack
            if (card.rank == (Rank)11)
            {
                //If the Jacks suit matches the Crib Cards suit
                if(card.suit == cribCard.suit)
                {
                    PointsAwarded(card + " and " + cribCard + " gave you a NOBS for", 2);
                    value = true;
                }
            }
            return value;
        }

        /// <summary>
        /// Calculates the score for a Players hand with the Crib Card included.
        /// </summary>
        /// <param name="hand">A Players hand (4 cards)</param>
        /// <param name="cribCard">The Crib Card</param>
        /// <returns>an int (The calculated score)</returns>
        public static int Calculate(Hand hand, Card cribCard)
        {
            hand.Sort();
            //Check for Nobs
            foreach(Card card in hand)
            {
                //Console.WriteLine(card.ToString() +" "+ card.GetHashCode());
                if (IsNobs(card, cribCard))
                {
                    score += 2;
                }
            }
            Console.WriteLine("\nPOINTS SUMMARY\n==================================");
            
            /////////////////////////////////////////////////////
            #region CHECK FOR DOUBLES

            if (CompareCardRanks(hand[i], hand[i+1]))
            {
                score += 2;
            }
            if (CompareCardRanks(hand[i], hand[i+2]))
            {
                score += 2;
            }
            if (CompareCardRanks(hand[i], hand[i+3]))
            {
                score += 2;
            }
            if (CompareCardRanks(hand[i], cribCard))
            {
                score += 2;
            }
            //SECOND CARD
            if (CompareCardRanks(hand[i+1], hand[i+2]))
            {
                score += 2;
            }
            if (CompareCardRanks(hand[i+1], hand[i+3]))
            {
                score += 2;
            }
            if (CompareCardRanks(hand[i+1], cribCard))
            {
                score += 2;
            }
            //THIRD CARD
            if (CompareCardRanks(hand[i+2], hand[i+3]))
            {
                score += 2;
            }
            if (CompareCardRanks(hand[i+2], cribCard))
            {
                score += 2;
            }
            //FOURTH CARD
            if (CompareCardRanks(hand[i+3], cribCard))
            {
                score += 2;
            }
            
            #endregion
            #region CHECK FOR 15's
            //Card 1,2
            score += FindFifthteens(hand[i], hand[i + 1]);
            //Card 1,3
            score += FindFifthteens(hand[i], hand[i + 2]);
            //Card 1,4
            score += FindFifthteens(hand[i], hand[i + 3]);
            //Card 1,5
            score += FindFifthteens(hand[i], cribCard);
            //Card 1,2,3
            score += FindFifthteens(hand[i], hand[i + 1], hand[i + 2]);
            //Card 1,2,4
            score += FindFifthteens(hand[i], hand[i + 1], hand[i + 3]);
            //Card 1,3,4
            score += FindFifthteens(hand[i], hand[i + 2], hand[i + 3]);
            //Card 1,2,5
            score += FindFifthteens(hand[i], hand[i + 1], cribCard);
            //Card 1,3,5
            score += FindFifthteens(hand[i], hand[i + 2], cribCard);
            //Card 1,4,5
            score += FindFifthteens(hand[i], hand[i + 3], cribCard);
            //Card 1,2,3,4
            score += FindFifthteens(hand[i], hand[i + 1], hand[i + 2], hand[i + 3]);

            //Card 2,3
            score += FindFifthteens(hand[i+1], hand[i + 2]);
            //Card 2,4
            score += FindFifthteens(hand[i + 1], hand[i + 3]);
            //Card 2,5
            score += FindFifthteens(hand[i+1], cribCard);
            //Card 2,3,4
            score += FindFifthteens(hand[i+1], hand[i + 2], hand[i + 3]);
            //Card 2,3,5
            score += FindFifthteens(hand[i + 1], hand[i + 2], cribCard);
            //Card 2,4,5
            score += FindFifthteens(hand[i + 1], hand[i + 3], cribCard);
            //Card 2,3,4,5
            score += FindFifthteens(hand[i+1], hand[i + 2], hand[i + 3], cribCard);

            //Card 3,4
            score += FindFifthteens(hand[i + 2], hand[i + 3]);
            //Card 3,5
            score += FindFifthteens(hand[i + 2], cribCard);
            //Card 3,4,5
            score += FindFifthteens(hand[i + 2], hand[i + 3], cribCard);

            //Card 4,5
            score += FindFifthteens(hand[i + 3], cribCard);

            //Add all 5 cards together
            score += FindFifthteens(hand[i], hand[i + 1], hand[i + 2], hand[i + 3], cribCard);

            #endregion
            #region CHECK FOR RUNs
            //Check for runs
            CheckRuns(hand);
            #endregion
            
            Console.WriteLine("\nPoints: " + score);
            return score;
        }
    }
}
