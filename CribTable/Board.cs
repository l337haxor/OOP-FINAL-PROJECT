using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace CribTable
{
    public partial class Board : Form
    {
        #region FIELDS AND PROPERTIES
        /// <summary>
        /// 
        /// </summary>
        private Hand cribHand = new Hand();
        /// <summary>
        /// 
        /// </summary>
        private const int cardSelectionLimit = 2;
        /// <summary>
        /// 
        /// </summary>
        private int amountOfCardsSelected = 0;
        /// <summary>
        /// 
        /// </summary>
        private Cards selectedCards = new Cards();

        /// <summary>
        /// For determining if its the draw phase
        /// </summary>
        public bool isDrawPhase = true;
        /// <summary>
        /// 
        /// </summary>
        public bool isDealPhase = false;
        /// <summary>
        /// 
        /// </summary>
        public bool isPegPhase = false;
        /// <summary>
        /// 
        /// </summary>
        public bool IsDecisionPhase = false;
        /// <summary>
        /// The amount, in points, that CardBox controls are enlarged when hovered over. 
        /// </summary>
        private const int POP = 50;

        /// <summary>
        /// The regular size of a CardBox control
        /// </summary>
        static private Size regularSize = new Size(110, 180);
        /// <summary>
        /// 
        /// </summary>
        private int numberOfPlayers;
        /// <summary>
        /// Used to generate Card objects from a Deck
        /// </summary>
        private static Deck deck = new Deck();
       
        /// <summary>
        /// 
        /// </summary>
        private PegBoardHand pegBoard = new PegBoardHand();
        ///
        private int cardsLimit = 1;
        //
        private Timer timer = new Timer();
        /// <summary>
        /// 
        /// </summary>

        //Players
        private Player player1 = new Player();
        private Player cpu1 = new Player();
        private Player cpu2 = new Player();
        
        //private CardBox.CardBox aCardbox;

        private Panel[] playerPanels;

        public Player[] players;

        private Game game;

        public void SetPlayers(int numberOfPlayers)
        {
            
            players[0] = player1;
            players[0].PlayerName = "Player 1";
            players[0].PlayerPanel = pnlPlayerHand;
            players[1] = cpu1;
            players[1].PlayerName = "CPU 1";
            players[1].PlayerPanel = pnlCpu1;
        
            if (numberOfPlayers > 2)
            {
                
                players[2] = cpu2;
                players[2].PlayerPanel = pnlCPU2;
                players[2].PlayerName = "CPU 2";
            }
        }
        public void WireEvents(CardBox.CardBox cardBox)
        {
            // Wire events handlers to the new control:
            cardBox.Click += CardBox_Click;
        }
        #endregion

        #region FORM AND STATIC CONTROL EVENT HANDLERS

        /// <summary>
        /// Deal a card or reset the deck on clicking the deck.
        /// </summary>
        private void pbDeck_Click(object sender, EventArgs e)
        {
          
        }
        #endregion

        #region CARD BOX EVENT HANDLERS

        /// <summary>
        /// When a CardBox is clicked, move to the opposite panel.
        /// </summary>
        public void CardBox_Click(object sender, EventArgs e)
        {
            // Convert sender to a CardBox
            CardBox.CardBox aCardBox = sender as CardBox.CardBox;
            
            // If the conversion worked
            if (aCardBox != null)
            {
                //
                if (aCardBox.Card.isSelected == false)
                {
                    //
                    if (amountOfCardsSelected < 2)
                    {
                        // Enlarge the card for visual effect
                        aCardBox.Size = new Size(regularSize.Width + POP, regularSize.Height + POP);
                        // move the card to the top edge of the panel.
                        aCardBox.Top = 0;
                        //
                        aCardBox.Card.isSelected = true;
                        //
                        RealignCards(player1.PlayerPanel);
                        //
                        amountOfCardsSelected++;
                        //
                        selectedCards.Add(aCardBox.Card as Card);
                    }
                }
                //
                else
                {
                    // resize the card back to regular size
                    aCardBox.Size = regularSize;
                    // move the card down to accommodate for the smaller size.
                    aCardBox.Top = POP;
                    //
                    aCardBox.Card.isSelected = false;
                    //
                    RealignCards(player1.PlayerPanel);
                    //
                    amountOfCardsSelected--;
                    //
                    selectedCards.Remove(aCardBox.Card as Card);
                }
            }
        }
        
        #endregion

        #region HELPER METHODS

        /// <summary>
        /// Repositions the cards in a panel so that they are evenly distributed in the area available.
        /// </summary>
        /// <param name="panelHand"></param>
        public void RealignCards(Panel panelHand)
        {
            // Determine the number of cards/controls in the panel.
            int myCount = panelHand.Controls.Count;

            // If there are any cards in the panel
            if (myCount > 0)
            {
                // Determine how wide one card/control is.
                int cardWidth = panelHand.Controls[0].Width;
                // Determine where the left-hand edge of a card/control placed 
                // in the middle of the panel should be  
                int startPoint = (panelHand.Width - cardWidth) / 2;
                // An offset for the remaining cards
                int offset = 0;
                // If there are more than one cards/controls in the panel
                if (myCount > 1)
                {
                    // Determine what the offset should be for each card based on the 
                    // space available and the number of card/controls
                    offset = ((cardWidth+10) -1 * POP) / (myCount - 1);
                    // If the offset is bigger than the card/control width, i.e. there is lots of room, 
                    // set the offset to the card width. The cards/controls will not overlap at all.
                    if (offset > cardWidth)
                        offset = cardWidth;

                    // Determine width of all the cards/controls 
                    int allCardsWidth = (myCount - 1) * offset + cardWidth;
                    // Set the start point to where the left-hand edge of the "first" card should be.
                    startPoint = (panelHand.Width - allCardsWidth) / 2;
                }

                // Aligning the cards: Note that I align them in reserve order from how they
                // are stored in the controls collection. This is so that cards on the left 
                // appear underneath cards to the right. This allows the user to see the rank
                // and suit more easily.

                // Align the "first" card (which is the last control in the collection)
                panelHand.Controls[myCount - 1].Top = POP;
                System.Diagnostics.Debug.Write(panelHand.Controls[myCount - 1].Top.ToString() + "\n");
                panelHand.Controls[myCount - 1].Left = startPoint;
                // for each of the remaining controls, in reverse order.

                for (int index = myCount - 2; index >= 0; index--)
                {
                    // Align the current card
                    panelHand.Controls[index].Top = POP;
                    panelHand.Controls[index].Left = panelHand.Controls[index + 1].Left + offset;
                }
            }
        }

        #endregion

        private void mnuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlPlay_Paint(object sender, PaintEventArgs e)
        {

        }
  
        public Board(string statusText, int numOfPlayers)
        {
            InitializeComponent();

            this.lblMessages.Text = statusText;
            numberOfPlayers = numOfPlayers;
        }
        public Board()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void Board_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlPlayerhand_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCpu2_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }
        #region CARD BOX EVENT HANDLERS
        
        #endregion
        private void btnActions_Click(object sender, EventArgs e)
        {
            if (isDrawPhase)
            {
                //
                players = new Player[numberOfPlayers];
                //
                playerPanels = new Panel[numberOfPlayers];
                //
                game = new Game(ref players, deck, numberOfPlayers);
                //
                SetPlayers(numberOfPlayers);
               
                //
                lblMessages.Text = amountOfCardsSelected.ToString();
                //
                Player winningPlayer = game.DrawCards(ref players, ref deck, cardsLimit);
                //
                lblMessages.Text = winningPlayer.ToString();
                //
                isDrawPhase = false;
                //
                isDealPhase = true;
                //
                btnActions.Text = "Click here to deal the hands.";
            }
           
            else if (isDealPhase)
            {
                cardsLimit = 6;
                //
                deck = new Deck();
                //
                game.ClearCards(ref players);
                //
                game.DealHands(ref players, ref deck, cardsLimit, false);
                //
                isDealPhase = false;
                //
                IsDecisionPhase = true;

                //
                btnActions.Text = "Click here to add selected cards to the crib.";

            }
            else if(IsDecisionPhase)
            {
               
                //
                //if (selectedCards.Count >= 1)
                //{
                //game.SendToCrib(ref player1, ref selectedCards, ref cribHand, ref pnlPlayerCrib);
                //
                //game.ClearCards(ref players);
                //}
            }
            else if(isPegPhase)
            {

            }
        }
    }
}