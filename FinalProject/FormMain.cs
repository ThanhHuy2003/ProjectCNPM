using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NextSlider_Click(object sender, EventArgs e)
        {

        }

        private void LastSlider_Click(object sender, EventArgs e)
        {

        }
        public void setChoice(Krypton.Toolkit.KryptonLabel lbl, Krypton.Toolkit.KryptonButton btn, Boolean flag)
        {
            int n = Int32.Parse(lbl.Text);
            if (flag)
                lbl.Text = (n + 1).ToString();
            else
            {
                if (n > 0)
                    lbl.Text = (n - 1).ToString();
            }
        }
        private void PlusItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, PlusItemMain1, true);

        }

        private void SubItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, SubItemMain1, false);

        }
        private void PlusItem2_Click(object sender, EventArgs e)
        {
            setChoice(CountItem2, PlusItemMain2, true);
        }

        private void SubItem2_Click(object sender, EventArgs e)
        {
            setChoice(CountItem2, SubItemMain2, false);
        }

        private void PlusItem3_Click(object sender, EventArgs e)
        {
            setChoice(CountItem3, PlusItemMain3, true);
        }

        private void SubItem3_Click(object sender, EventArgs e)
        {
            setChoice(CountItem3, SubItemMain3, false);

        }
    }
}
