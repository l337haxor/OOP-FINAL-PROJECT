namespace FormUIDemo
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.FormUiDemoTips = new System.Windows.Forms.ToolTip(this.components);
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.pnlCardHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCardCount = new System.Windows.Forms.Label();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.optClick = new System.Windows.Forms.RadioButton();
            this.optDrag = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(20, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.FormUiDemoTips.SetToolTip(this.btnExit, "Exit the application.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbDeck
            // 
            this.pbDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDeck.Location = new System.Drawing.Point(20, 55);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(75, 108);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeck.TabIndex = 2;
            this.pbDeck.TabStop = false;
            this.FormUiDemoTips.SetToolTip(this.pbDeck, "Click the deck to draw a card.");
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pnlCardHome
            // 
            this.pnlCardHome.AllowDrop = true;
            this.pnlCardHome.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlCardHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardHome.Location = new System.Drawing.Point(123, 215);
            this.pnlCardHome.Name = "pnlCardHome";
            this.pnlCardHome.Size = new System.Drawing.Size(529, 134);
            this.pnlCardHome.TabIndex = 10;
            this.FormUiDemoTips.SetToolTip(this.pnlCardHome, "Click cards to move them to the play area.");
            this.pnlCardHome.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.pnlCardHome.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            this.pnlCardHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardHome_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Home Area:";
            this.FormUiDemoTips.SetToolTip(this.label1, "Home ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Play Area:";
            this.FormUiDemoTips.SetToolTip(this.label2, "Home ");
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(676, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            this.mnuMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMainMenu_ItemClicked);
            // 
            // miAbout
            // 
            this.miAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(52, 20);
            this.miAbout.Text = "&About";
            this.miAbout.ToolTipText = "Information about this program";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // lblCardCount
            // 
            this.lblCardCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblCardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCardCount.Location = new System.Drawing.Point(21, 24);
            this.lblCardCount.Name = "lblCardCount";
            this.lblCardCount.Size = new System.Drawing.Size(75, 32);
            this.lblCardCount.TabIndex = 1;
            this.lblCardCount.Text = "88";
            this.lblCardCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCardCount.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pnlPlay
            // 
            this.pnlPlay.AllowDrop = true;
            this.pnlPlay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlay.Location = new System.Drawing.Point(123, 53);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(529, 134);
            this.pnlPlay.TabIndex = 8;
            this.pnlPlay.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.pnlPlay.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            this.pnlPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlay_Paint);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click the deck to deal a card to the Home Area.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(20, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // optClick
            // 
            this.optClick.AutoSize = true;
            this.optClick.Checked = true;
            this.optClick.Location = new System.Drawing.Point(27, 233);
            this.optClick.Name = "optClick";
            this.optClick.Size = new System.Drawing.Size(48, 17);
            this.optClick.TabIndex = 3;
            this.optClick.TabStop = true;
            this.optClick.Text = "Clic&k";
            this.optClick.UseVisualStyleBackColor = true;
            this.optClick.CheckedChanged += new System.EventHandler(this.optClick_CheckedChanged);
            // 
            // optDrag
            // 
            this.optDrag.AutoSize = true;
            this.optDrag.Location = new System.Drawing.Point(27, 257);
            this.optDrag.Name = "optDrag";
            this.optDrag.Size = new System.Drawing.Size(48, 17);
            this.optDrag.TabIndex = 4;
            this.optDrag.Text = "&Drag";
            this.optDrag.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(676, 365);
            this.Controls.Add(this.optDrag);
            this.Controls.Add(this.optClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPlay);
            this.Controls.Add(this.pnlCardHome);
            this.Controls.Add(this.lblCardCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form UI Demo";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip FormUiDemoTips;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.Label lblCardCount;
        private System.Windows.Forms.Panel pnlCardHome;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton optClick;
        private System.Windows.Forms.RadioButton optDrag;
    }
}

