using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace ClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a test hand (4cards + crib card)////

            // Card card1 = new Card((Suit)3, (Rank)7);
            ///Card card2 = new Card((Suit)3, (Rank)8);
            //Card card3 = new Card((Suit)3, (Rank)1);
            //Card card4 = new Card((Suit)1, (Rank)1);

            Hand hand = new Hand();

            Card cribCard = new Card((Suit)3, (Rank)10);
            hand.Add(new Card((Suit)1, (Rank)2));
            hand.Add(new Card((Suit)1, (Rank)2));
            hand.Add(new Card((Suit)1, (Rank)3));
            hand.Add(new Card((Suit)1, (Rank)5));
            hand.Add(cribCard);
            /////////////////////////////////////

            ////////////////////////////////////////////

            Console.WriteLine("TEST HAND\n\n");
            //Calculate the score
            Score.Calculate(hand, cribCard);
            //pause
            Console.ReadKey();
        }
    }
}

