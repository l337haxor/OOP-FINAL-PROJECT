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
            int score = 0;
            Hand hand = new Hand();

            //Deck deck = new Deck();

            Card cribCard = new Card((Suit)3, (Rank)8);
            try
            {
                
                hand.Add(new Card((Suit)1, (Rank)8));
                hand.Add(new Card((Suit)3, (Rank)10));
                hand.Add(new Card((Suit)2, (Rank)7));
                hand.Add(new Card((Suit)0, (Rank)6));
                //hand.Add(new Card((Suit)2, (Rank)7));
                //hand.Add(new Card((Suit)0, (Rank)6));

            }
            catch( IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        
            //Calculate the score
            score = Score.Calculate(hand, cribCard);
            //Display the points awarded

            Console.WriteLine("\nPoints: " + score);

            //pause
            Console.ReadKey();
        }
    }
}

