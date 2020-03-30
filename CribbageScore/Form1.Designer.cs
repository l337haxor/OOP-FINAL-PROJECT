namespace CribbageScore
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.lbTitle = new System.Windows.Forms.Label();
            this.bt2Players = new System.Windows.Forms.Button();
            this.lbGame = new System.Windows.Forms.Label();
            this.toolTipPurchaseOption = new System.Windows.Forms.ToolTip(this.components);
            this.bnTutorial = new System.Windows.Forms.Button();
            this.bnStats = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            this.bt3Players = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAbout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(337, 41);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Cribbage Card Game";
            // 
            // bt2Players
            // 
            this.bt2Players.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2Players.Location = new System.Drawing.Point(14, 19);
            this.bt2Players.Name = "bt2Players";
            this.bt2Players.Size = new System.Drawing.Size(161, 33);
            this.bt2Players.TabIndex = 1;
            this.bt2Players.Text = "2 Players";
            this.bt2Players.UseVisualStyleBackColor = true;
            this.bt2Players.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.BackColor = System.Drawing.Color.Transparent;
            this.lbGame.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGame.Location = new System.Drawing.Point(272, 339);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(77, 28);
            this.lbGame.TabIndex = 0;
            this.lbGame.Text = "GAME";
            this.lbGame.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTipPurchaseOption
            // 
            this.toolTipPurchaseOption.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // bnTutorial
            // 
            this.bnTutorial.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTutorial.Image = global::CribbageScore.Properties.Resources.Alecive_Flatwoken_Apps_Game_Cards;
            this.bnTutorial.Location = new System.Drawing.Point(6, 61);
            this.bnTutorial.Name = "bnTutorial";
            this.bnTutorial.Size = new System.Drawing.Size(161, 36);
            this.bnTutorial.TabIndex = 4;
            this.bnTutorial.Text = "Tutorial";
            this.bnTutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipPurchaseOption.SetToolTip(this.bnTutorial, " Tutorial on how to play the game");
            this.bnTutorial.UseVisualStyleBackColor = true;
            this.bnTutorial.Click += new System.EventHandler(this.bnTutorial_Click);
            // 
            // bnStats
            // 
            this.bnStats.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnStats.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnStats.Image = global::CribbageScore.Properties.Resources.Stats_Aha_Soft_Large_Seo_SEO;
            this.bnStats.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bnStats.Location = new System.Drawing.Point(6, 19);
            this.bnStats.Name = "bnStats";
            this.bnStats.Size = new System.Drawing.Size(161, 36);
            this.bnStats.TabIndex = 3;
            this.bnStats.Text = "Statistic";
            this.bnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipPurchaseOption.SetToolTip(this.bnStats, "Statistic on past games");
            this.bnStats.UseVisualStyleBackColor = true;
            this.bnStats.Click += new System.EventHandler(this.bnStats_Click);
            // 
            // bnExit
            // 
            this.bnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnExit.Location = new System.Drawing.Point(521, 494);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(94, 29);
            this.bnExit.TabIndex = 6;
            this.bnExit.Text = "Exit";
            this.toolTipPurchaseOption.SetToolTip(this.bnExit, "Click to Exit the game");
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bt3Players
            // 
            this.bt3Players.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3Players.Location = new System.Drawing.Point(14, 58);
            this.bt3Players.Name = "bt3Players";
            this.bt3Players.Size = new System.Drawing.Size(161, 33);
            this.bt3Players.TabIndex = 2;
            this.bt3Players.Text = "3 Players";
            this.bt3Players.UseVisualStyleBackColor = true;
            this.bt3Players.Click += new System.EventHandler(this.bt3Players_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.bt3Players);
            this.groupBox2.Controls.Add(this.bt2Players);
            this.groupBox2.Location = new System.Drawing.Point(127, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.bnStats);
            this.groupBox3.Controls.Add(this.bnTutorial);
            this.groupBox3.Location = new System.Drawing.Point(314, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.Color.Transparent;
            this.btAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbout.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbout.Location = new System.Drawing.Point(2, 494);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(156, 29);
            this.btAbout.TabIndex = 5;
            this.btAbout.Text = "About Team 1";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmMain
            // 
            this.AcceptButton = this.bt2Players;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::CribbageScore.Properties.Resources._55f5f5e74d27602962b197c5656f1bca_old_women_playing_cards_illustrations_royalty_free_vector__612_5331;
            this.CancelButton = this.bnStats;
            this.ClientSize = new System.Drawing.Size(627, 526);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbGame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(643, 565);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(643, 565);
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team1 Final Project";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ToolTip toolTipPurchaseOption;
        private System.Windows.Forms.Button bnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt3Players;
        private System.Windows.Forms.Button bt2Players;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnStats;
        private System.Windows.Forms.Button bnTutorial;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.Button btAbout;
    }
}

