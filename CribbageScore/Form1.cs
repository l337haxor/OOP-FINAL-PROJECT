using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CribbageScore
{
    public partial class FmMain : Form
    {
        //Global Variables

        //The number of players selected
        public int numberOfPlayers;
        public string statusText;

        public FmMain()
        {
            
            InitializeComponent();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            statusText = "Welcome to cribbage, to start please click on the deck to cut your card";
            //
            numberOfPlayers = 2;
            //
            CribTable.Board boardForm = new CribTable.Board(statusText, numberOfPlayers);
            //
            boardForm.Show();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                            "Sterling Wenzelbach - Lead Programmer, " +
                            "Rogel Corral - Programmer, " +
                            "Neil Creary - Tester, " +
                            "Gaetane Bedard - GUI design and documentation." );
            
             
        }

        private void bt3Players_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Option to be released at a later date");
        }

        private void bnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To activate this option your must purchase the game." + 
                "  Please login to your account and dowload the full " +
                " version of the game.");
        }

        private void bnTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To activate this option your must purchase the game." +
                "  Please login to your account and dowload the full " +
                " version of the game.");
        }
    }
}
