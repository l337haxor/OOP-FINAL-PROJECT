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
using System.Windows.Forms;

namespace ClassLib
{
    /// <summary>
    /// A player class, (a card player)
    /// </summary>
    public class Player
    {
        //players name
        public string PlayerName { get;  set; }
        //players hard
        public Hand PlayHand { get;  set; }
        //players score
        public int PlayerScore { get;  set; }
        //players card panel
        public Panel PlayerPanel { get; set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Player()
        {

            //create a hand
            PlayHand = new Hand();
            //initialize score to 0
            PlayerScore = 0;
            //
            PlayerPanel = new Panel();
        }
        /// <summary>
        /// Parameterized constructor - add players name
        /// </summary>
        /// <param name="name">the players name</param>
        public Player(string name)
        {
            //set the name
            PlayerName = name;
            //create a hand
            PlayHand = new Hand();
            //initialize score to 0
            PlayerScore = 0;
            //
            PlayerPanel = new Panel();
        }

        public override string ToString()
        {
            return PlayerName;
        }
    }
}
