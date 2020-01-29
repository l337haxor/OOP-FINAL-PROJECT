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
       


        public static int Calculate(Card[] hand, Card cribCard)
        {
            foreach(Card card in hand)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine(cribCard.ToString());
            /////////////////////////////////////////////////////
            if (hand[i] == hand[i + 1])
            {
                score += 2;
            }

            /*
            if (hand[i] == hand[i + 2])
            {
                score += 2;
            }

            if (hand[i] == hand[i + 3])
            {
                score += 2;
            }
            */ 
            return score;
        }
    }
}
