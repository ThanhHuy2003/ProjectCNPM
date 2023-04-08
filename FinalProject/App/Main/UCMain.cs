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
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void NextSlider_Click(object sender, EventArgs e)
        {
            if (Radbutton.Checked)
            {
                Radbutton.Checked = false;
                ImageSlider.Visible = false;
                Radbutton2.Checked = true;
                ImageSlider2.Visible = true;
            }
            else if (Radbutton2.Checked)
            {
                Radbutton2.Checked = false;
                ImageSlider2.Visible = false;
                Radbutton3.Checked = true;
                ImageSlider3.Visible = true;
            }
            else if (Radbutton3.Checked)
            {
                Radbutton3.Checked = false;
                ImageSlider3.Visible = false;
                Radbutton4.Checked = true;
                ImageSlider4.Visible = true;
            }
            else if (Radbutton4.Checked)
            {
                Radbutton4.Checked = false;
                ImageSlider4.Visible = false;
                Radbutton5.Checked = true;
                ImageSlider5.Visible = true;

            }
            else if (Radbutton5.Checked)
            {
                Radbutton5.Checked = false;
                ImageSlider5.Visible = false;
                Radbutton.Checked = true;
                ImageSlider.Visible = true;
            }
        }

        private void LastSlider_Click(object sender, EventArgs e)
        {
            if (Radbutton.Checked)
            {
                Radbutton.Checked = false;
                ImageSlider.Visible = false;
                Radbutton5.Checked = true;
                ImageSlider5.Visible = true;
            }
            else if (Radbutton5.Checked)
            {
                Radbutton5.Checked = false;
                ImageSlider5.Visible = false;
                Radbutton4.Checked = true;
                ImageSlider4.Visible = true;
            }
            else if (Radbutton4.Checked)
            {
                Radbutton4.Checked = false;
                ImageSlider4.Visible = false;
                Radbutton3.Checked = true;
                ImageSlider3.Visible = true;
            }
            else if (Radbutton3.Checked)
            {
                Radbutton3.Checked = false;
                ImageSlider3.Visible = false;
                Radbutton2.Checked = true;
                ImageSlider2.Visible = true;

            }
            else if (Radbutton2.Checked)
            {
                Radbutton2.Checked = false;
                ImageSlider2.Visible = false;
                Radbutton.Checked = true;
                ImageSlider.Visible = true;
            }
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

        private void PlusItemMain1_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain1, PlusItemMain1, true);

        }

        private void SubItemMain1_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain1, SubItemMain1, false);
        }

        private void PlusItemMain2_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain2, PlusItemMain2, true);

        }

        private void SubItemMain2_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain2, SubItemMain2, false);

        }

        private void PlusItemMain3_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain3, PlusItemMain3, true);

        }

        private void SubItemMain3_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain3, SubItemMain3, false);

        }
    }
}
