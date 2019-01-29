using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_LynnetteWarnberg
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }
        //private void cancelQuoteButton(object sender, EventArgs e)
        //{
        //    var mainMenu = (MainMenu)Tag;
        //    mainMenu.Show();
        //    Close();
        //}

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
