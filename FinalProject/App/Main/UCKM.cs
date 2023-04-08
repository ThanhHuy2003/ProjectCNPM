using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App
{
    public partial class UCKM : UserControl
    {
        public UCKM()
        {
            InitializeComponent();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search";
                SearchTextbox.ForeColor = Color.Silver;
            }
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search")
            {
                SearchTextbox.Text = "";
                SearchTextbox.ForeColor = Color.Black;
            }
        }
    }
}
