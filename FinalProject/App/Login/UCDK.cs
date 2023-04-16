using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.Main;

namespace FinalProject.App.Login
{
    public partial class UCDK : UserControl
    {
        Login login2 = new Login();
        public UCDK()
        {
            InitializeComponent();
        }
        private UCDK uCDK;
        private void btnDN_Click(object sender, EventArgs e)
        {
            panel_DN.Visible = true;
            panel_DN.Size = new System.Drawing.Size(525, 710);
            panel_DN.Location = new System.Drawing.Point(0, 0);
            Func.togglePanel(login2, panel_DN, "DN");
            login2.Controls.Remove(uCDK);
        }

        private void FullNameText_Enter(object sender, EventArgs e)
        {
            if (FullNameText.Text == "Full name")
            {
                FullNameText.Text = "";
                FullNameText.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void FullNameText_Leave(object sender, EventArgs e)
        {
            if (FullNameText.Text == "")
            {
                FullNameText.Text = "Full name";
                FullNameText.StateActive.Content.Color1 = Color.Silver;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (EmailText.Text == "Email")
            {
                EmailText.Text = "";
                EmailText.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (EmailText.Text == "")
            {
                EmailText.Text = "Email";
                EmailText.StateActive.Content.Color1 = Color.Silver;
            }
        }

        private void ContactText_Enter(object sender, EventArgs e)
        {
            if (ContactText.Text == "Contact address")
            {
                ContactText.Text = "";
                ContactText.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void ContactText_Leave(object sender, EventArgs e)
        {
            if (ContactText.Text == "")
            {
                ContactText.Text = "Contact address";
                ContactText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void ProvinceText_Enter(object sender, EventArgs e)
        {
            if (ProvinceText.Text == "Province")
            {
                ProvinceText.Text = "";
                ProvinceText.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void ProvinceText_Leave(object sender, EventArgs e)
        {
            if (ProvinceText.Text == "")
            {
                ProvinceText.Text = "Province";
                ProvinceText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void UserNameText_Enter(object sender, EventArgs e)
        {
            if (UserNameText.Text == "Username")
            {
                UserNameText.Text = "";
                UserNameText.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void UserNameText_Leave(object sender, EventArgs e)
        {
            if (UserNameText.Text == "")
            {
                UserNameText.Text = "Username";
                UserNameText.StateActive.Content.Color1 = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.StateActive.Content.Color1 = Color.Black;
                PasswordText.UseSystemPasswordChar = true;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";
                PasswordText.StateActive.Content.Color1 = Color.Silver;
            }
        }

        private void Eye2_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text.Length > 0)
            {
                Blind2.BringToFront();
                PasswordText.UseSystemPasswordChar = false;
            }
        }

        private void Blind2_Click(object sender, EventArgs e)
        {
            Eye2.BringToFront();
            PasswordText.UseSystemPasswordChar = true;
        }

        private void UCDK_Load(object sender, EventArgs e)
        {
            lblSignUp.Select();
        }
        private void UCDK_Clicked(object sender, EventArgs e)
        {
            lblSignUp.Select();
        }
    }
}
