/*


REFERENCE: https://github.com/msherman/Cribbage/blob/master/Cribbage.java

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class Score
    {
        //Stores the score for a hand
        static int returnScore = 0;
      
        /// <summary>
        /// Output string for console 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="points"></param>
        public static void PointsAwarded(string message, string points)
        {
            Console.WriteLine("\n"+ message + " " + points + " points!\n");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="cribCard"></param>
        /// <returns></returns>
        private static int CheckRuns(Hand hand, Card cribCard)
        {
            //Stores points awarded
            int score = 0;
            //Number of runs
            int multiplier = 1;

            int currentMultiplierCard = 0;

            int thisCard;
            int nextCard;
            int currentCard;
            StringBuilder runHandDisplay = new StringBuilder();

            Hand runHand = new Hand();

            for (currentCard = 0; currentCard < hand.Count - 1; currentCard++)
            {
                thisCard = (int)hand[currentCard].rank;
                nextCard = (int)hand[currentCard + 1].rank;

                if (thisCard == nextCard - 1)
                {
                    //Console.WriteLine("TEST1");
                    runHand.Add(new Card(hand[currentCard].Suit, (Rank)thisCard));
                    
                    score++;
                }
                else if (thisCard == nextCard)
                {
                    
                    if (currentMultiplierCard == thisCard || currentMultiplierCard == 0)
                    {
                        //Console.WriteLine("TEST2");
                        
                        multiplier++;

                        currentMultiplierCard = thisCard;
                        runHand.Add(new Card(hand[currentCard].Suit, (Rank)thisCard));
                        //runHand.Add(new Card(hand[currentCard].Suit, hand[multiplier+2].rank));
                    }
                    else
                    {
                        //Console.WriteLine("TEST3");
                        multiplier *= 2;
                        runHand.Add(new Card(hand[currentCard].Suit, (Rank)thisCard));
                        
                    }
                }
                else if (score < 2)
                {
                    Console.WriteLine("NO RUN");
                    score = 0;
                    multiplier = 1;
                }
                else
                {
                    //stop the loop
                    currentCard = 99;
                }
            }

            if (score > 1)
            {

                score = (score + 1) * multiplier;
                runHand.Sort();

                foreach (Card card in runHand)
                {
                    //Console.WriteLine(card);
                    runHandDisplay.Append(card.ToString() + " ");
                }
                for (int count = multiplier; count > 0; count--)
                {
                    PointsAwarded(runHandDisplay + " gave you a RUN for", (score/multiplier).ToString());
                }
            }
            
            //return the score
            Console.WriteLine("\nnum of runs: " + multiplier + "\n");
            return score;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="cribCard"></param>
        /// <returns></returns>
        private static int FindFifteens(Hand hand, Card cribCard)
        {
            //Stores points awarded
            int score = 0;
            //Compare first card
            for (int firstCard = 0; firstCard < hand.Count; firstCard++)
            {
                //Compare second card
                for (int secondCard = firstCard + 1; secondCard < hand.Count; secondCard++)
                {
                    //Compare 2 cards
                    if ((int)hand[firstCard].rank + (int)hand[secondCard].rank == 15)
                    {
                        //increase score by 2
                        PointsAwarded(hand[firstCard] + " and " + hand[secondCard] + " gave you a 15 for", "2");
                        score += 2;
                    }

                    //Compare third card
                    for (int threeCard = secondCard + 1; threeCard < hand.Count; threeCard++)
                    {
                        //Compare 3 cards
                        if ((int)hand[firstCard].rank + (int)hand[secondCard].rank + (int)hand[threeCard].rank == 15)
                        {
                            //increase score by 2
                            PointsAwarded(hand[firstCard] + " and " + hand[secondCard] + " and " + hand[threeCard] + " gave you a 15 for", "2");
                            score += 2;
                        }

                        //Compare forth card
                        for (int fourCard = threeCard + 1; fourCard < hand.Count; fourCard++)
                        {
                            //Compare 4 cards
                            if ((int)hand[firstCard].rank + (int)hand[secondCard].rank + (int)hand[threeCard].rank + (int)hand[fourCard].rank == 15)
                            {
                                //increase score by 2
                                PointsAwarded(hand[firstCard] + " and " + hand[secondCard] + " and " + hand[threeCard] + " and " + hand[fourCard] + " gave you a 15 for", "2");
                                score += 2;
                            }
                        }
                    }
                }
            }
            //Add all five cards together
            if ((int)hand[0].rank + (int)hand[1].rank + (int)hand[2].rank + (int)hand[3].rank + (int)hand[4].rank == 15)
            {
                //increase score by 2
                PointsAwarded(hand[0] + " and " + hand[1] + " and " + hand[2] + " and " + hand[3] + hand[4] + " gave you a 15 for", "2");
                score += 2;
            }

            //return the score
            return score;
        }
        /// <summary>
        /// Compares the rank of 2 cards and returns a true/false value.
        /// </summary>
        /// <param name="card1">a Card object</param>
        /// <param name="card2">a Card object</param>
        /// <returns>true/false</returns>
        private static int Doubles(Hand hand, Card cribCard)
        {
            //Stores points awarded
            int score = 0;
            //Loop through cards in hand
            for (int count = 0; count < hand.Count - 1; count++)
            {
                //Loop through adjacent cards
                for (int innerCount = count + 1; innerCount < hand.Count; innerCount++)
                {
                    //If cards are the same (difference in hash codes)
                    if (hand[count].CompareTo(hand[innerCount]) == 0)
                    {
                        //increase score
                        PointsAwarded(hand[count] + " and " + hand[innerCount] + " is a Pair for", "2");
                        score += 2;
                    }
                }

            }
            //return the score 
            return score;
        }
        /// <summary>
        /// Checks to see if a card is a Jack and its suit matches the Crib Card
        /// </summary>
        /// <param name="card">a Card object</param>
        /// <param name="cribCard">The Crib Card</param>
        /// <returns>true/false</returns>
        private static int IsNobs(Hand hand, Card cribCard)
        {
            //Stores the return score
            int score = 0;
            //Loop through each card in the hand
            foreach (Card card in hand)
            {
                //If the card is a jack
                if (card.rank == (Rank)11)
                {
                    //If the Jacks suit matches the Crib Cards suit
                    if (card.suit == cribCard.suit)
                    {
                        PointsAwarded(card + " and " + cribCard + " gave you a NOBS for", "1");
                        //increase score by 1
                        score += 1;
                    }
                }
            }
            //return the score 
            return score;
        }

        /// <summary>
        /// Calculates the score for a Players hand with the Crib Card included.
        /// </summary>
        /// <param name="hand">A Players hand (4 cards)</param>
        /// <param name="cribCard">The Crib Card</param>
        /// <returns>an int (The calculated score)</returns>
        public static int Calculate(Hand hand, Card cribCard)
        {
           
            //CHECK FOR NOBS
            returnScore += IsNobs(hand, cribCard);

            //Add crib into hand for processing
            hand.Add(cribCard);
            //Sort the hand by lowest to highest rank
            //hand.Sort();

            //CHECK FOR DOUBLES
            returnScore += Doubles(hand, cribCard);
            
            //CHECK FOR 15's
            returnScore += FindFifteens(hand, cribCard);

            //CHECK FOR RUNs
            returnScore += CheckRuns(hand, cribCard);
            
            //DISPLAY HAND==================================================================
            foreach (Card card in hand)
            {
                Console.WriteLine(card.ToString() + " " + " Card Rank : " + (int)card.Rank);
            }
            Console.WriteLine("\nPOINTS SUMMARY\n==================================");
            //==============================================================================

            //Return the score 
            
            return returnScore;
        }
    }
}
