using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace FinalProject
{
    
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Username")
            {
                UsernameText.Text = "";
                UsernameText.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.Text == "")
            {
                UsernameText.Text = "Username";
                UsernameText.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";
                PasswordText.ForeColor = Color.Silver;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select();
            label4.Select();
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text.Length > 0)
            {
                Blind.BringToFront();
                PasswordText.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eye.BringToFront();
            PasswordText.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible= true;
            label3.Visible= false;
            label5.Visible= true;
            label4.Select();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            label3.Visible = true;
            label5.Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PasswordText2.Text.Length > 0)
            {
                Blind2.BringToFront();
                PasswordText2.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eye2.BringToFront();
            PasswordText2.UseSystemPasswordChar = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameText_Enter(object sender, EventArgs e)
        {
            if (FullNameText.Text == "Full Name")
            {
                FullNameText.Text = "";
                FullNameText.ForeColor = Color.Silver;
            }
        }

        private void FullNameText_Leave(object sender, EventArgs e)
        {
            if (FullNameText.Text == "")
            {
                FullNameText.Text = "Full Name";
                FullNameText.ForeColor = Color.Silver;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (EmailText.Text == "Email address")
            {
                EmailText.Text = "";
                EmailText.ForeColor = Color.Silver;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (EmailText.Text == "")
            {
                EmailText.Text = "Email address";
                EmailText.ForeColor = Color.Silver;
            }
        }

        private void ContactText_Enter(object sender, EventArgs e)
        {
            if (ContactText.Text == "Contact address")
            {
                ContactText.Text = "";
                ContactText.ForeColor = Color.Silver;
            }
        }

        private void ContactText_Leave(object sender, EventArgs e)
        {
            if (ContactText.Text == "")
            {
                ContactText.Text = "Contact address";
                ContactText.ForeColor = Color.Silver;
            }
        }

        private void UserNameText2_Enter(object sender, EventArgs e)
        {
            if (UserNameText2.Text == "Username")
            {
                UserNameText2.Text = "";
                UserNameText2.ForeColor = Color.Silver;
            }
        }

        private void UserNameText2_Leave(object sender, EventArgs e)
        {
            if (UserNameText2.Text == "")
            {
                UserNameText2.Text = "Username";
                UserNameText2.ForeColor = Color.Silver;
            }
        }

        private void PasswordText2_Enter(object sender, EventArgs e)
        {
            if (PasswordText2.Text == "Password")
            {
                PasswordText2.Text = "";
                PasswordText2.ForeColor = Color.Silver;
            }
        }

        private void PasswordText2_Leave(object sender, EventArgs e)
        {
            if (PasswordText2.Text == "")
            {
                PasswordText2.Text = "Password";
                PasswordText2.ForeColor = Color.Silver;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Select();
            label4.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

   

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mov;
        int movX;
        int movY;
        private void kryptonPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void kryptonPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void kryptonPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
