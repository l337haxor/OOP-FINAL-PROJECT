// * 
// * Author: Sterling Wenzelbach
// * Since: 2020-02-03, edited: 2020-02-09
// * 
// * Source: 
//            Beginning Visual C# 2012 Programming
//            Chapter 13 - 
//            Wrox Press © 2013

// */

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using CribTable;

namespace ClassLib
{
    /// <summary>
    /// The Game 
    /// </summary>
    public class Game 
    {
        //       
        Board board = new Board();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <param name="deck"></param>
        /// <param name="numOfPlayers"></param>
        public Game(ref Player[] players, Deck deck, int numOfPlayers)
        {

        }
        /// <summary>
        /// sets the number of players in the game
        /// </summary>
        /// <param name="newPlayers"> number of players</param>
        //public static Player[] SetPlayers(Player player)
        //{
        //    Player[] players = new Player[player];
        //    if (newPlayers.Length > 3)
        //        throw new ArgumentException("A maximum of 3 players may play this" +
        //                                    " game.");

        //    if (newPlayers.Length < 2)
        //        throw new ArgumentException("A minimum of 2 players may play this" +
        //                                    " game.");
        //    return players;
        //}

        /// <summary>
        /// Deals hands to all players in the game
        /// </summary>
        public void DealHands(ref Player[] players, ref Deck deck, int cardLimit, bool drawPhase)
        {
            //
            Card card;
            //
            for (int count = 0; count < players.Length; count++)
            {
                //
                for (int dealtCards = 1; dealtCards <= cardLimit; dealtCards++)
                {
                    //
                    card = deck.DealRandomCard();
                    //
                    if (count == 0)
                    {
                        card.FaceUp = true;
                    }
                    else
                    {
                        if (drawPhase == true)
                        {
                            card.FaceUp = true;
                        }
                        else
                        {
                            card.FaceUp = false;
                        }
                    }
                    //
                    players[count].PlayHand.Add(card);
                    //
                    CardBox.CardBox aCardBox = new CardBox.CardBox(card);
                    //
                    if(count == 0 )
                    {
                        if (drawPhase != true)
                        {
                            board.WireEvents(aCardBox);
                        }
                    }
                   
                    //
                    players[count].PlayerPanel.Controls.Add(aCardBox);
                  
                }
                board.RealignCards(players[count].PlayerPanel);
            }
            
        }
        public Player DrawCards(ref Player[] players, ref Deck deck, int cardLimit)
        {
            Player winningPlayer = new Player();
            
            int value = 0;

            DealHands(ref players, ref deck, cardLimit, true);

            foreach(Player player in players)
            {
                if (player.PlayHand[0].Rank > (Rank)value)
                {
                    winningPlayer = player;
                }
                //If the ranks are equal, compare suit value
                else if (player.PlayHand[0].Rank == (Rank)value)
                {
                    if (player.PlayHand[0].Suit > (Suit)value)
                    {
                        winningPlayer = player;
                    }
                }
            }
            //Return the player with the highest card drawed
            return winningPlayer;
        }

        public void SendToCrib(ref Player player, ref Cards cards, ref Hand cribHand, ref Panel panel)
        {
            //
            CardBox.CardBox aCardBox; 
            //
            for (int count = cards.Count -1 ; count >= 0; count--)
            {
                //
                aCardBox = new CardBox.CardBox(cards[count]);
                //
                panel.Controls.Add(aCardBox);
                //
                cribHand.Add(cards[count]);
                //
                player.PlayHand.RemoveAt(count);
                //
                panel.Controls.RemoveAt(count);
            }
            //
            board.RealignCards(player.PlayerPanel);
           
        }

        public Card PlayCard(ref Player player, ref Card card, ref PegBoardHand pegBoard, ref Panel panel)
        {
            pegBoard.Add(card);

            player.PlayHand.Remove(card);

            return card;
        }

        public void ClearCards(ref Player[] players)
        {
            //
            for (int count = players.Length - 1; count >= 0; count--)
            {
                //
                for (int cards = players[count].PlayHand.Count - 1; cards > 0; cards--)
                {
                    //
                    players[count].PlayHand.RemoveAt(count);
                    //
                    players[count].PlayerPanel.Controls.Clear();
                }
            }
        }
    }
}




