using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10CardLib;

namespace Ch10CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //create a default deck
            Deck myDeck = new Deck();
            //shuffle it
            myDeck.Shuffle();

            //display all the cards in the deck
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                //add an , if its not the last card in the loop
                if (i != 51)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            */
            //make a test hand
            Card[] hand = new Card[4];
            hand[0] = new Card((Suit)1, (Rank)3);
            hand[1] = new Card((Suit)2, (Rank)2);
            hand[2] = new Card((Suit)1, (Rank)2);
            hand[3] = new Card((Suit)1, (Rank)3);

            Card cribCard = new Card((Suit)1, (Rank)4);

            Console.WriteLine("TEST HAND\n\n");
            Score.Calculate(hand, cribCard);

            Console.ReadKey();
        }
    }
}

