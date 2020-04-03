using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormUIDemo
{
    public partial class frmAboutForm : Form
    {
        public frmAboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
