/*
 * Copied from: 
                Beginning Visual C# 2012 Programming
                Chapter 10 - Defining Class Members
            Exercise 10.5
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Exercise10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deal 5 cards at once until the deck is empty and check if all the suits match
            while (true)
            {
                //create new deck
                Deck playDeck = new Deck();
                //shuffle it
                playDeck.Shuffle();
                // flush boolean
                bool isFlush = false;

                int flushHandIndex = 0;

                for (int hand = 0; hand < 10; hand++)
                {
                    isFlush = true;

                    Suit flushSuit = playDeck.GetCard(hand * 5).suit;

                    for (int card = 1; card < 5; card++)
                    {
                        if (playDeck.GetCard(hand * 5 + card).suit != flushSuit)
                        {
                            isFlush = false;
                        }
                    }
                    if (isFlush)
                    {
                        flushHandIndex = hand * 5;
                        break;
                    }
                }
                //if all suits match
                if (isFlush)
                {
                    //display all 5 cards
                    Console.WriteLine("Flush!");
                    for (int card = 0; card < 5; card++)
                    {
                        Console.WriteLine(playDeck.GetCard(flushHandIndex + card));
                    }
                }
                //if no flush
                else
                {
                    Console.WriteLine("No flush.");
                }
                Console.ReadLine();
            }
        }
    }
}
