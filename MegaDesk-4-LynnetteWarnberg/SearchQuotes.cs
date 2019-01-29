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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void CancelQuoteSearch_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
