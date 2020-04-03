using ClassLib;

namespace CribTable
{
    partial class Board
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
            this.lblMessages = new System.Windows.Forms.Label();
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.pnlPlayerHand = new System.Windows.Forms.Panel();
            this.pnlCpu1 = new System.Windows.Forms.Panel();
            this.pnlPegBoard = new System.Windows.Forms.Panel();
            this.pnlCPU2 = new System.Windows.Forms.Panel();
            this.lblCpu1 = new System.Windows.Forms.Label();
            this.lblCpu2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnActions = new System.Windows.Forms.Button();
            this.pnlCPU1Crib = new System.Windows.Forms.Panel();
            this.pnlCPU2Crib = new System.Windows.Forms.Panel();
            this.pnlPlayerCrib = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessages
            // 
            this.lblMessages.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblMessages.Location = new System.Drawing.Point(447, 578);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(428, 43);
            this.lblMessages.TabIndex = 0;
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessages.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbDeck
            // 
            this.pbDeck.BackColor = System.Drawing.SystemColors.Window;
            this.pbDeck.Image = global::CribTable.Properties.Resources.Deck1;
            this.pbDeck.Location = new System.Drawing.Point(880, 416);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(130, 154);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDeck.TabIndex = 16;
            this.pbDeck.TabStop = false;
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pnlPlayerHand
            // 
            this.pnlPlayerHand.AllowDrop = true;
            this.pnlPlayerHand.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerHand.Location = new System.Drawing.Point(446, 715);
            this.pnlPlayerHand.Name = "pnlPlayerHand";
            this.pnlPlayerHand.Size = new System.Drawing.Size(428, 134);
            this.pnlPlayerHand.TabIndex = 17;
            this.pnlPlayerHand.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlayerhand_Paint);
            // 
            // pnlCpu1
            // 
            this.pnlCpu1.AllowDrop = true;
            this.pnlCpu1.BackColor = System.Drawing.Color.Transparent;
            this.pnlCpu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCpu1.Location = new System.Drawing.Point(382, 35);
            this.pnlCpu1.Name = "pnlCpu1";
            this.pnlCpu1.Size = new System.Drawing.Size(423, 134);
            this.pnlCpu1.TabIndex = 18;
            // 
            // pnlPegBoard
            // 
            this.pnlPegBoard.AllowDrop = true;
            this.pnlPegBoard.BackColor = System.Drawing.Color.Green;
            this.pnlPegBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPegBoard.Location = new System.Drawing.Point(446, 426);
            this.pnlPegBoard.Name = "pnlPegBoard";
            this.pnlPegBoard.Size = new System.Drawing.Size(428, 134);
            this.pnlPegBoard.TabIndex = 19;
            // 
            // pnlCPU2
            // 
            this.pnlCPU2.AllowDrop = true;
            this.pnlCPU2.BackColor = System.Drawing.Color.Transparent;
            this.pnlCPU2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCPU2.Location = new System.Drawing.Point(12, 426);
            this.pnlCPU2.Name = "pnlCPU2";
            this.pnlCPU2.Size = new System.Drawing.Size(423, 134);
            this.pnlCPU2.TabIndex = 20;
            // 
            // lblCpu1
            // 
            this.lblCpu1.AutoSize = true;
            this.lblCpu1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpu1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCpu1.Location = new System.Drawing.Point(554, 11);
            this.lblCpu1.Name = "lblCpu1";
            this.lblCpu1.Size = new System.Drawing.Size(61, 21);
            this.lblCpu1.TabIndex = 0;
            this.lblCpu1.Text = "CPU 1";
            // 
            // lblCpu2
            // 
            this.lblCpu2.AutoSize = true;
            this.lblCpu2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpu2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCpu2.Location = new System.Drawing.Point(177, 402);
            this.lblCpu2.Name = "lblCpu2";
            this.lblCpu2.Size = new System.Drawing.Size(66, 21);
            this.lblCpu2.TabIndex = 0;
            this.lblCpu2.Text = "CPU 2";
            this.lblCpu2.Click += new System.EventHandler(this.lblCpu2_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer.Location = new System.Drawing.Point(631, 691);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(82, 21);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player()";
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // btnActions
            // 
            this.btnActions.Location = new System.Drawing.Point(446, 634);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(429, 41);
            this.btnActions.TabIndex = 21;
            this.btnActions.Text = "Start!";
            this.btnActions.UseVisualStyleBackColor = true;
            this.btnActions.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // pnlCPU1Crib
            // 
            this.pnlCPU1Crib.AllowDrop = true;
            this.pnlCPU1Crib.BackColor = System.Drawing.Color.Transparent;
            this.pnlCPU1Crib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCPU1Crib.Location = new System.Drawing.Point(140, 35);
            this.pnlCPU1Crib.Name = "pnlCPU1Crib";
            this.pnlCPU1Crib.Size = new System.Drawing.Size(236, 134);
            this.pnlCPU1Crib.TabIndex = 19;
            // 
            // pnlCPU2Crib
            // 
            this.pnlCPU2Crib.AllowDrop = true;
            this.pnlCPU2Crib.BackColor = System.Drawing.Color.Transparent;
            this.pnlCPU2Crib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCPU2Crib.Location = new System.Drawing.Point(12, 265);
            this.pnlCPU2Crib.Name = "pnlCPU2Crib";
            this.pnlCPU2Crib.Size = new System.Drawing.Size(236, 134);
            this.pnlCPU2Crib.TabIndex = 20;
            // 
            // pnlPlayerCrib
            // 
            this.pnlPlayerCrib.AllowDrop = true;
            this.pnlPlayerCrib.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerCrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerCrib.Location = new System.Drawing.Point(199, 715);
            this.pnlPlayerCrib.Name = "pnlPlayerCrib";
            this.pnlPlayerCrib.Size = new System.Drawing.Size(236, 134);
            this.pnlPlayerCrib.TabIndex = 21;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CribTable.Properties.Resources._55f5f5e74d27602962b197c5656f1bca_old_women_playing_cards_illustrations_royalty_free_vector__612_533;
            this.ClientSize = new System.Drawing.Size(1572, 861);
            this.Controls.Add(this.pnlPlayerCrib);
            this.Controls.Add(this.pnlCPU2Crib);
            this.Controls.Add(this.pnlCPU1Crib);
            this.Controls.Add(this.lblCpu1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblCpu2);
            this.Controls.Add(this.btnActions);
            this.Controls.Add(this.pnlCPU2);
            this.Controls.Add(this.pnlPegBoard);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.pnlCpu1);
            this.Controls.Add(this.pnlPlayerHand);
            this.Controls.Add(this.pbDeck);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(11500, 900);
            this.MinimumSize = new System.Drawing.Size(1072, 716);
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team1 Final Project";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.Panel pnlPlayerHand;
        private System.Windows.Forms.Panel pnlCpu1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCpu1;
        private System.Windows.Forms.Panel pnlPegBoard;
        private System.Windows.Forms.Panel pnlCPU2;
        private System.Windows.Forms.Label lblCpu2;
        private System.Windows.Forms.Button btnActions;
        private System.Windows.Forms.Panel pnlCPU1Crib;
        private System.Windows.Forms.Panel pnlCPU2Crib;
        private System.Windows.Forms.Panel pnlPlayerCrib;
    }
}

