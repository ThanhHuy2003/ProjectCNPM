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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonPanel5.Visible = false;
            kryptonPanel2.Visible = true;
            kryptonPanel8.Visible = false;
            kryptonPanel11.Visible = false;
            kryptonPanel14.Visible = false;
            PanelMain.Visible= false;
            PanelTD.Visible = true;
            PanelKM.Visible = false;
        }
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            kryptonPanel5.Visible = true;
            kryptonPanel2.Visible = false;
            kryptonPanel8.Visible = false;
            kryptonPanel11.Visible = false;
            kryptonPanel14.Visible = false;
            PanelMain.Visible = false;
            PanelTD.Visible = false;
            PanelKM.Visible = true;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            kryptonPanel5.Visible = false;
            kryptonPanel2.Visible = false;
            kryptonPanel8.Visible = true;
            kryptonPanel11.Visible = false;
            kryptonPanel14.Visible = false;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            kryptonPanel5.Visible = false;
            kryptonPanel2.Visible = false;
            kryptonPanel8.Visible = false;
            kryptonPanel11.Visible = true;
            kryptonPanel14.Visible = false;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            kryptonPanel5.Visible = false;
            kryptonPanel2.Visible = false;
            kryptonPanel8.Visible = false;
            kryptonPanel11.Visible = false;
            kryptonPanel14.Visible = true;
        }
        int mov;
        int movX;
        int movY;
        private void kryptonPanel18_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void kryptonPanel18_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void kryptonPanel18_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
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
        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
        }

        

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "    Search...";
                SearchTextbox.ForeColor = Color.Silver;
            }
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "    Search...")
            {
                SearchTextbox.Text = "";
                SearchTextbox.ForeColor = Color.Black;
            }
        }



        private void PlusItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, PlusItem1, true);

        }

        private void SubItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItemMain1, SubItemMain1, false);

        }
        private void PlusItem2_Click(object sender, EventArgs e)
        {
            setChoice(CountItem2, PlusItem2, true);
        }

        private void SubItem2_Click(object sender, EventArgs e)
        {
            setChoice(CountItem2, SubItem2, false);
        }

        private void PlusItem3_Click(object sender, EventArgs e)
        {
            setChoice(CountItem3, PlusItem3, true);
        }

        private void SubItem3_Click(object sender, EventArgs e)
        {
            setChoice(CountItem3, SubItem3, false);

        }

        private void PlusItem4_Click(object sender, EventArgs e)
        {
            setChoice(CountItem4, PlusItem4, true);

        }

        private void SubItem4_Click_1(object sender, EventArgs e)
        {
            setChoice(CountItem4, SubItem4, false);
        }

        private void PlusItem5_Click(object sender, EventArgs e)
        {
            setChoice(CountItem5, PlusItem5, true);

        }

        private void SubItem5_Click(object sender, EventArgs e)
        {
            setChoice(CountItem5, SubItem5, false);
        }

        private void PlusItem6_Click(object sender, EventArgs e)
        {
            setChoice(CountItem6, PlusItem6, true);

        }

        private void SubItem6_Click(object sender, EventArgs e)
        {
            setChoice(CountItem6, SubItem6, false);
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

        private void Main_Load(object sender, EventArgs e)
        {

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
