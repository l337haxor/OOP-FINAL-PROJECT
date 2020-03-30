/* MainForm.cs  - Defines the MainForm class
 * 
 * Author: Sterling Wenzelbach
 * Since: 2020-02-12
 * 
 
 */
using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardBoxTester
{
    /// <summary>
    /// Testing the CardBox Control
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Card theCard = new Card();
            theCard.FaceUp = true;
            this.cbxTestCard.Card = theCard;

        }

        private void btnFlipCard_Click(object sender, EventArgs e)
        {
            //flip the card
            cbxTestCard.FaceUp = !cbxTestCard.FaceUp;
        }

        private void cmbRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the suit of the card to the selected suit
            cbxTestCard.Suit = (ClassLib.Suit)cmbSuits.SelectedIndex;
        }

        private void cmbRanks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //change the rank of the card to the selected rank
            cbxTestCard.Rank = (ClassLib.Rank)cmbRanks.SelectedIndex+1;
        }

        private void cbxTestCard_Click(object sender, EventArgs e)
        {
            lblClicked.Text = cbxTestCard.ToString() + " was clicked last.";
            if (cbxTestCard.CardOrientation == Orientation.Horizontal)
                cbxTestCard.CardOrientation = Orientation.Vertical;
            else
                cbxTestCard.CardOrientation = Orientation.Horizontal;
        }

        private void lblClicked_Click(object sender, EventArgs e)
        {

        }

        private void cbxTestCard_Load(object sender, EventArgs e)
        {

        }

        //a counter for how many times the card flips
        private int flipCount = 0;
        private void cbxTestCard_CardFlipped(object sender, EventArgs e)
        {
            flipCount++; //increase flip counter
            lblFlipped.Text = "Card flip: " + flipCount.ToString(); // output to label
        }
    }
}
