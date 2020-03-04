﻿/* Card.cs  - Defines the Card class
 * 
 * Author: Sterling Wenzelbach
 * Since: 2020-02-03
 * 
 * Soruce: 
            Beginning Visual C# 2012 Programming
            Chapter 11 - Collections, Comparisons, and Conversions
            Wrox Press © 2013

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ClassLib
{
    /// <summary>
    /// a card class, inherits the Icloneable interface
    /// </summary>
    public class Card : ICloneable
    {
        public Image GetCardImage()
        {
            string imageName; // the resource file name
            Image cardImage; // holds the image

            //if the card is not face up
            if(!faceUp)
            {
                //set image to this card image
                imageName = "cardBack_red2"; // back of card
            }
            //not face down
            else
            {
                imageName = "card" + suit.ToString() + rank.ToString();
            }

            cardImage = CardLib.Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            return cardImage;
        }
        /// <summary>
        /// Used to set or get whether a card is face up or face down
        /// </summary>
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }
        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Clubs;

        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        // fixed values
        public Suit suit;
        public Rank rank;

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
            this.rank = Rank.Ace;
        }

        /// <summary>
        /// ToSting - card info
        /// </summary>
        /// <returns> a string displaying the card information + an "s" at the end</returns>
        public override string ToString()
        {
            return "The " + rank + " of " + suit;
        }

        /// <summary>
        /// Method to create a shallow copy of an object
        /// </summary>
        /// <returns>a shallow copy of the object</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <summary>
        /// Overloads the == operator to compare 2 cards
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }
        /// <summary>
        /// Overloads the != operator to compare 2 cards
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
        /// <summary>
        /// Overrides the Equals method to compare 2 cards
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }
        /// <summary>
        /// Overloads the GetHashCode() method to create a custom hash code
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }
        /// <summary>
        /// Overloads the > operator to compare 2 cards (compares ranks and trump)
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public static bool operator >(Card card1, Card card2)
        {
            //if the suits are the same
            if (card1.suit == card2.suit)
            {
                //if ace are high cards
                if (isAceHigh)
                {
                    //if card1 rank is an ace
                    if (card1.rank == Rank.Ace)
                    {
                        //if card2 rank is also an ace, then card2 is not greater
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    //card1 is not an ace
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                //if aces arent high
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            //
            else
            {
                //if card2 is trump, card1 is not greater
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        /// <summary>
        /// Overloads the < operator to compare 2 cards
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }
        /// <summary>
        /// Overloads the >= operator to compare 2 cards
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        /// <summary>
        /// Overloads the <= operator to compare 2 cards
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <param name="card2">a card object</param>
        /// <returns>true/false</returns>
        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }
    }
}

