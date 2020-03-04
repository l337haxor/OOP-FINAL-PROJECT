namespace CardBoxTester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClassLib.Card card1 = new ClassLib.Card();
            this.btnFlipCard = new System.Windows.Forms.Button();
            this.cbxTestCard = new CardBox.CardBox();
            this.cmbSuits = new System.Windows.Forms.ComboBox();
            this.cmbRanks = new System.Windows.Forms.ComboBox();
            this.lblClicked = new System.Windows.Forms.Label();
            this.lblFlipped = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlipCard
            // 
            this.btnFlipCard.Location = new System.Drawing.Point(49, 28);
            this.btnFlipCard.Name = "btnFlipCard";
            this.btnFlipCard.Size = new System.Drawing.Size(75, 23);
            this.btnFlipCard.TabIndex = 0;
            this.btnFlipCard.Text = "&Flip Card";
            this.btnFlipCard.UseVisualStyleBackColor = true;
            this.btnFlipCard.Click += new System.EventHandler(this.btnFlipCard_Click);
            // 
            // cbxTestCard
            // 
            card1.FaceUp = false;
            this.cbxTestCard.Card = card1;
            this.cbxTestCard.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxTestCard.FaceUp = false;
            this.cbxTestCard.Location = new System.Drawing.Point(49, 57);
            this.cbxTestCard.Name = "cbxTestCard";
            this.cbxTestCard.Rank = ClassLib.Rank.Ace;
            this.cbxTestCard.Size = new System.Drawing.Size(75, 107);
            this.cbxTestCard.Suit = ClassLib.Suit.Clubs;
            this.cbxTestCard.TabIndex = 1;
            this.cbxTestCard.CardFlipped += new System.EventHandler(this.cbxTestCard_CardFlipped);
            this.cbxTestCard.Click += new System.EventHandler(this.cbxTestCard_Click);
            this.cbxTestCard.Load += new System.EventHandler(this.cbxTestCard_Load);
            // 
            // cmbSuits
            // 
            this.cmbSuits.FormattingEnabled = true;
            this.cmbSuits.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cmbSuits.Location = new System.Drawing.Point(177, 57);
            this.cmbSuits.Name = "cmbSuits";
            this.cmbSuits.Size = new System.Drawing.Size(121, 21);
            this.cmbSuits.TabIndex = 2;
            this.cmbSuits.Text = "Suits";
            this.cmbSuits.SelectedIndexChanged += new System.EventHandler(this.cmbRanks_SelectedIndexChanged);
            // 
            // cmbRanks
            // 
            this.cmbRanks.FormattingEnabled = true;
            this.cmbRanks.Items.AddRange(new object[] {
            "Ace",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King"});
            this.cmbRanks.Location = new System.Drawing.Point(177, 84);
            this.cmbRanks.Name = "cmbRanks";
            this.cmbRanks.Size = new System.Drawing.Size(121, 21);
            this.cmbRanks.TabIndex = 3;
            this.cmbRanks.Text = "Ranks";
            this.cmbRanks.SelectedIndexChanged += new System.EventHandler(this.cmbRanks_SelectedIndexChanged_1);
            // 
            // lblClicked
            // 
            this.lblClicked.AutoSize = true;
            this.lblClicked.Location = new System.Drawing.Point(174, 117);
            this.lblClicked.Name = "lblClicked";
            this.lblClicked.Size = new System.Drawing.Size(104, 13);
            this.lblClicked.TabIndex = 4;
            this.lblClicked.Text = "Card not clicked yet.";
            this.lblClicked.Click += new System.EventHandler(this.lblClicked_Click);
            // 
            // lblFlipped
            // 
            this.lblFlipped.AutoSize = true;
            this.lblFlipped.Location = new System.Drawing.Point(174, 151);
            this.lblFlipped.Name = "lblFlipped";
            this.lblFlipped.Size = new System.Drawing.Size(101, 13);
            this.lblFlipped.TabIndex = 5;
            this.lblFlipped.Text = "Card not flipped yet.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 192);
            this.Controls.Add(this.lblFlipped);
            this.Controls.Add(this.lblClicked);
            this.Controls.Add(this.cmbRanks);
            this.Controls.Add(this.cmbSuits);
            this.Controls.Add(this.cbxTestCard);
            this.Controls.Add(this.btnFlipCard);
            this.Name = "MainForm";
            this.Text = "CardBox Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlipCard;
        private CardBox.CardBox cbxTestCard;
        private System.Windows.Forms.ComboBox cmbSuits;
        private System.Windows.Forms.ComboBox cmbRanks;
        private System.Windows.Forms.Label lblClicked;
        private System.Windows.Forms.Label lblFlipped;
    }
}

