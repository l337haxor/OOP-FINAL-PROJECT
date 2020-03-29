using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;
using ClassLib;

namespace ClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Hand hand = new Hand();
          
            Deck deck = new Deck();

            Card cribCard = new Card((Suit)3, (Rank)10);
            hand.Add(new Card((Suit)1, (Rank)8));
            hand.Add(new Card((Suit)0, (Rank)9));
            hand.Add(new Card((Suit)2, (Rank)8));
            hand.Add(new Card((Suit)3, (Rank)7));
   
            //Calculate the score
            score = Score.Calculate(hand, cribCard);
            //Display the points awarded

            Console.WriteLine("\nPoints: " + score);

            //pause
            Console.ReadKey();
        }
    }
}

