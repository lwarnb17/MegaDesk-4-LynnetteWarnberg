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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }
        private void CancelQuoteButton(object sender, EventArgs e)
        {
            
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
