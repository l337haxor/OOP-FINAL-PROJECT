/* Player.cs  - Defines the Player class
 *
 * Author: Sterling Wenzelbach
 * Since: 2020-02-09
 *
 * Source: 
            Beginning Visual C# 2012 Programming
            Chapter 13
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
    /// A playey class, (a card player)
    /// </summary>
    public class Player
    {
        //players name
        public string Name { get; private set; }
        //players hard
        public Cards PlayHand { get; private set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        private Player()
        {
        }
        /// <summary>
        /// Parameterized constructor - add players name
        /// </summary>
        /// <param name="name">the players name</param>
        public Player(string name)
        {
            //set the name
            Name = name;
            //create a hand
            PlayHand = new Cards();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>true/false</returns>
        public bool HasWon()
        {
            //return value
            bool won = true;
            //matching suit is card 0 suit
            Suit match = PlayHand[0].suit;

            //loop trough hand
            for (int i = 1; i < PlayHand.Count; i++)
            {
                //if a card suit matches card 0 suit, won = true
                won &= PlayHand[i].suit == match;
            }

            return won;
        }
    }
}
