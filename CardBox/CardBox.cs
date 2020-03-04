/* CardBox.cs  - Defines the CardBox class
 * 
 * Author: Sterling Wenzelbach
 * Since: 2020-02-012
 * 

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace CardBox
{
    /// <summary>
    /// A control to use a Windows Forms Application that displays a playing card.
    /// </summary>
    public partial class CardBox: UserControl
    {
        #region FIELDS AND PROPERTIES


        /// <summary>
        /// Card Property: gets/sets the underlying Card object
        /// </summary>
        private Card myCard;
        public Card Card
        {
            get
            {
                return myCard;
            }
            set
            {
                myCard = value;
                //update the card image
                UpdateCardImage();
            }
        }
        /// <summary>
        /// Suit Property: gets/sets the underlying Cards suit
        /// </summary>
        public Suit Suit
        {
            get
            {
                return Card.suit;
            }
            set
            {
                Card.suit = value;
                //update the card image
                UpdateCardImage();
            }
        }
        /// <summary>
        /// Rank Property: gets/sets the underlying Cards rank
        /// </summary>
        public Rank Rank
        {
            get
            {
                return Card.rank;

            }
            set
            {
                Card.rank = value;
                //update the card image
                UpdateCardImage();
            }
        }
        /// <summary>
        /// FaceUp Property: gets/sets the underlying Cards FaceUp value
        /// </summary>
        public bool FaceUp
        {
            get
            {
                return Card.FaceUp;
            }
            set
            {
                //if the value is different than the underlying cards faceup property
                if(myCard.FaceUp != value) // then the card is flipping over
                {
                    myCard.FaceUp = value; // change the cards faceup property
                    UpdateCardImage(); //update image (back to front)

                    //if the cardflipped event handler is set
                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs()); //call it
                }
            
             
            }
        }
        /// <summary>
        /// gets/sets the orientation of the card
        /// if setting the property changes the state of the control,
        /// swaps the height and width of the control and updates the image.
        /// </summary>
        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            get
            {
                return myOrientation;
            }
            set
            {
                //if value is different than myOrientation
                if(myOrientation != value)
                {
                    //change the orientation
                    myOrientation = value;
                    //swap the height and wwidth of the control
                    this.Size = new Size(Size.Height, Size.Width);
                    //update the card image
                    UpdateCardImage();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateCardImage()
        {
            //set the image of the underlying card
            pbMyPictureBox.Image = myCard.GetCardImage();
            //if the orientation is horizontal
            if (myOrientation == Orientation.Horizontal)
            {
                //rotate the image
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor : Constructs the control with a new card, oriented vertically
        /// </summary>
        public CardBox()
        {
            InitializeComponent(); // required method for designer support
            myOrientation = Orientation.Vertical; // set orientation to veritcal
            myCard = new Card(); //create a new underlying card
        }
        /// <summary>
        /// Constructor: Using a card and orientation parameters
        /// </summary>
        /// <param name="card">a card object</param>
        /// <param name="orientation">Orientation enumertion</param>
        public CardBox(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent(); // required method for designer support
            myOrientation = Orientation.Vertical; // set orientation to veritcal
            myCard = card; //create a new underlying card
        }
        #endregion

        #region EVENTS AND EVENT HANDLERS

        #endregion

        #region OTHER METHODS
        /// <summary>
        /// overides the basic toString method
        /// </summary>
        /// <returns>the name of the card as a string</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }
        #endregion
        /// <summary>
        /// for load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage(); //update card image on load
        }
        /// <summary>
        /// An event the client program can handle when the card flips face up/down
        /// </summary>
        public event EventHandler CardFlipped;

        /// <summary>
        /// An event the client program can handle when the user clicks the control
        /// </summary>
        new public event EventHandler Click;

        /// <summary>
        /// when user clicks on picturebox (card)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if (Click != null) // is the event handler set
                Click(this, e); // call it
        }
     
    }
}
