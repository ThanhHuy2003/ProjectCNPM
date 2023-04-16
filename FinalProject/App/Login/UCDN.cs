using FinalProject.App.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static FinalProject.Main;

namespace FinalProject.App
{
    public partial class UCDN : UserControl
    {
        Login.Login login2 = new Login.Login();
        public UCDN()
        {
            InitializeComponent();
        }
        private UCDN uCDN;

        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel_DK.Visible = true;
            panel_DK.Size = new System.Drawing.Size(525,710);
            panel_DK.Location = new System.Drawing.Point(0, 0);
            Func.togglePanel(login2, panel_DK,"DK");
            login2.Controls.Remove(uCDN);

        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Username")
            {
                UsernameText.Text = "";
                UsernameText.StateActive.Content.Color1 = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.Text == "")
            {
                UsernameText.Text = "Username";
                UsernameText.StateActive.Content.Color1 = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.StateActive.Content.Color1 = Color.Black;
                PasswordText.UseSystemPasswordChar= true;
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

        private void Eye_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text.Length > 0)
            {
                Blind.BringToFront();
                PasswordText.UseSystemPasswordChar = false;
            }
        }

        private void Blind_Click(object sender, EventArgs e)
        {
            Eye.BringToFront();
            PasswordText.UseSystemPasswordChar = true;
        }

        private void UCDN_Load(object sender, EventArgs e)
        {
            lblSignIn.Select();
            
        }
        private void UCDN_Clicked(object sender, EventArgs e)
        {
            lblSignIn.Select();

        }

    }
}
