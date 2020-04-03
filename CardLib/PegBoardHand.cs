using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PegBoardHand: Hand
    {
       
        public PegBoardHand() : base()
        {
            //A peg board can only ever have 12 cards in play. 3 players (4 cards per player)
            this.maximumHandSize = 12;
            //errorMessage = "PegBoard exceed card limit of " + this.MaxHandSize + " cards!";
        }
    }
}
