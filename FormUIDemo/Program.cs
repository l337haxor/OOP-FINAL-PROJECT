/*  Program.cs - Defines the Program class for tutorial 9 
 * 
 *  Author:     Thom MacDonald
 *  Author:     Sterling Wenzelbach
 *  Since:      <2020-02-09>
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUIDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainForm());
        }
    }
}
