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
        /// For determining if its the draw phase
        /// </summary>
        private bool isDrawPhase = true;

        /// <summary>
        /// The amount, in points, that CardBox controls are enlarged when hovered over. 
        /// </summary>
        private const int POP = 25;

        /// <summary>
        /// The regular size of a CardBox control
        /// </summary>
        static private Size regularSize = new Size(25, 57);

        /// <summary>
        /// Used to generate Card objects from a Deck
        /// </summary>
        private Deck deck = new Deck();

        
        /// <summary>
        /// Refers to the card being dragged from one panel to another.
        /// </summary>
        private CardBox.CardBox dragCard;

        #endregion

        #region FORM AND STATIC CONTROL EVENT HANDLERS

      
        /// <summary>
        /// Deal a card or reset the deck on clicking the deck.
        /// </summary>
        private void pbDeck_Click(object sender, EventArgs e)
        {

            // Create a new card
            Card card = new Card();
            // Draw a card from the card dealer. If it worked...
            
                lblStatus.Text = "clicked";
                card = deck.DealRandomCard();
                // Create a new CardBox control based on the card drawn
                CardBox.CardBox aCardBox = new CardBox.CardBox(card);
                aCardBox.FaceUp = true;
                // Wire events handlers to the new control:
                //aCardBox.Click += CardBox_Click;

                // wire CardBox_MouseDown, CardBox_DragEnter, and CardBox_DragDrop
                aCardBox.MouseDown += CardBox_MouseDown;
                aCardBox.DragEnter += CardBox_DragEnter;
                aCardBox.DragDrop += CardBox_DragDrop;
                    
                // wire CardBox_MouseEnter for the "POP" visual effect
                aCardBox.MouseEnter += CardBox_MouseEnter;
                // wire CardBox_MouseLeave for the regular visual effect
                aCardBox.MouseLeave += CardBox_MouseLeave;
                // Add the new control to the appropriate panel
                pnlPlayerHand.Controls.Add(aCardBox);
                // Realign the controls in the panel so they appear correctly.
                RealignCards(pnlPlayerHand);
            
                
        }

        
        /// <summary>
        /// Make the mouse pointer a "move" pointer when a drag enters a Panel.
        /// </summary>
        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            // Make the mouse pointer a "move" pointer
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Move a card/control when it is dropped from one Panel to another.
        /// </summary>
        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            // If there is a CardBox to move
            if (dragCard != null)
            {
                // Determine which Panel is which
                Panel thisPanel = sender as Panel;
                Panel fromPanel = dragCard.Parent as Panel;
                // If neither panel is null (no conversion issue)
                if (thisPanel != null && fromPanel != null)
                {
                    // if the Panels are not the same 
                    if (thisPanel != fromPanel)
                    {
                        // (this would happen if a card is dragged from one spot in the Panel to another)
                        // Remove the card from the Panel it started in
                        fromPanel.Controls.Remove(dragCard);
                        // Add the card to the Panel it was dropped in 
                        thisPanel.Controls.Add(dragCard);
                        // Realign cards in both Panels
                        RealignCards(thisPanel);
                        RealignCards(fromPanel);
                    }
                }
            }
        }

        #endregion

        #region CARD BOX EVENT HANDLERS

        /// <summary>
        ///  CardBox controls grow in size when the mouse is over it.
        /// </summary>
        void CardBox_MouseEnter(object sender, EventArgs e)
        {
            // Convert sender to a CardBox
            CardBox.CardBox aCardBox = sender as CardBox.CardBox;

            // If the conversion worked
            if (aCardBox != null)
            {
                // Enlarge the card for visual effect
                aCardBox.Size = new Size(regularSize.Width + POP, regularSize.Height + POP);
                // move the card to the top edge of the panel.
                aCardBox.Top = 0;
            }
        }
        /// <summary>
        /// CardBox control shrinks to regular size when the mouse leaves.
        /// </summary>
        void CardBox_MouseLeave(object sender, EventArgs e)
        {
            // Convert sender to a CardBox
            CardBox.CardBox aCardBox = sender as CardBox.CardBox;
            // If the conversion worked
            if (aCardBox != null)
            {
                // resize the card back to regular size
                aCardBox.Size = regularSize;
                // move the card down to accommodate for the smaller size.
                aCardBox.Top = POP;
            }
        }
        /// <summary>
        /// Initiate a card move on the start of a drag.
        /// </summary>
        private void CardBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Set dragCard 
            dragCard = sender as CardBox.CardBox;
            // If the conversion worked
            if (dragCard != null)
            {
                // Set the data to be dragged and the allowed effect dragging will have.
                DoDragDrop(dragCard, DragDropEffects.Move);
            }
        }
        /// <summary>
        /// When a CardBox is clicked, move to the opposite panel.
        /// </summary>
        void CardBox_Click(object sender, EventArgs e)
        {
            // Convert sender to a CardBox
            CardBox.CardBox aCardBox = sender as CardBox.CardBox;

            // If the conversion worked
            if (aCardBox != null)
            {
                // if the card is in the home panel...
                if (aCardBox.Parent == pnlPlayerHand)
                {
                    // Remove the card from the home panel
                    pnlPlayerHand.Controls.Remove(aCardBox);
                    // Add the control to the play panel
                    pnlCpuHand.Controls.Add(aCardBox);
                }
                // otherwise...
                else
                {
                    // Remove the card from the play panel
                    pnlCpuHand.Controls.Remove(aCardBox);
                    // Add the control to the home panel
                    pnlPlayerHand.Controls.Add(aCardBox);
                }
                // Realign the cards 
                RealignCards(pnlPlayerHand);
                RealignCards(pnlCpuHand);
            }
        }

        /// <summary>
        /// When a drag is enters a card, enter the parent panel instead.
        /// </summary>
        private void CardBox_DragEnter(object sender, DragEventArgs e)
        {
            //// Convert sender to a CardBox
            CardBox.CardBox aCardBox = sender as CardBox.CardBox;

            //// If the conversion worked
            if (aCardBox != null)
            {
            //    // Do the operation on the parent panel instead
                Panel_DragEnter(aCardBox.Parent, e);
            }
        }

        /// <summary>
        /// When a drag is dropped on a card, drop on the parent panel instead.
        /// </summary>
        private void CardBox_DragDrop(object sender, DragEventArgs e)
        {
            //// Convert sender to a CardBox
            CardBox.CardBox aCardBox = sender as CardBox.CardBox;

            //// If the conversion worked
            if (aCardBox != null)
            {
            //    // Do the operation on the parent panel instead
                Panel_DragDrop(aCardBox.Parent, e);
            }
        }

        #endregion

        #region HELPER METHODS

        /// <summary>
        /// Repositions the cards in a panel so that they are evenly distributed in the area available.
        /// </summary>
        /// <param name="panelHand"></param>
        private void RealignCards(Panel panelHand)
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

        /// <summary>
        /// Clears the panels and reloads the deck.
        /// </summary>
        void ResetDealer()
        {
            // Clear the panels
            pnlPlayerHand.Controls.Clear();
            pnlCpuHand.Controls.Clear();

            

            // Set the image to a card back
            pbDeck.Image = (new Card()).GetCardImage();
            
        }
        #endregion

        private void mnuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlPlay_Paint(object sender, PaintEventArgs e)
        {

        }
        int numberOfPlayers;

        public Board(string statusText, int numOfPlayers)
        {
            InitializeComponent();

            this.lblStatus.Text = statusText;
            this.numberOfPlayers = numOfPlayers;
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
    }
}










