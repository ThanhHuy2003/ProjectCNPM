using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject
{
    
    public partial class Login : KryptonForm
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
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
            if (txtUsernameLogin.Text == "Username")
            {
                txtUsernameLogin.Text = "";
                txtUsernameLogin.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (txtUsernameLogin.Text == "")
            {
                txtUsernameLogin.Text = "Username";
                txtUsernameLogin.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text == "Password")
            {
                txtPasswordLogin.Text = "";
                txtPasswordLogin.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text == "")
            {
                txtPasswordLogin.Text = "Password";
                txtPasswordLogin.ForeColor = Color.Silver;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select();
            label4.Select();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text.Length > 0)
            {
                Blind.BringToFront();
                txtPasswordLogin.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eye.BringToFront();
            txtPasswordLogin.UseSystemPasswordChar = true;
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
            if (txtUserPassword.Text.Length > 0)
            {
                Blind2.BringToFront();
                txtUserPassword.UseSystemPasswordChar = false;
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
            txtUserPassword.UseSystemPasswordChar = true;
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
            if (txtFullName.Text == "Full Name")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.Silver;
            }
        }

        private void FullNameText_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Full Name";
                txtFullName.ForeColor = Color.Silver;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "Email address")
            {
                txtEmailAddress.Text = "";
                txtEmailAddress.ForeColor = Color.Silver;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "")
            {
                txtEmailAddress.Text = "Email address";
                txtEmailAddress.ForeColor = Color.Silver;
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
            if (txtUserName.Text == "Username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void UserNameText2_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void PasswordText2_Enter(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "Password")
            {
                txtUserPassword.Text = "";
                txtUserPassword.ForeColor = Color.Silver;
            }
        }

        private void PasswordText2_Leave(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "")
            {
                txtUserPassword.Text = "Password";
                txtUserPassword.ForeColor = Color.Silver;
            }
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

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void changeWhenClick(System.Windows.Forms.TextBox txtName, string textDefault)
        {
            txtName.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            if (txtName.Text.Equals(textDefault))
            {
                txtName.Text = "";
            }
        }
        private void txtFullName_Click(object sender, EventArgs e)
        {
            changeWhenClick(txtFullName, txtFullName.Text);
        }

        private void txtEmailAddress_Click(object sender, EventArgs e)
        {
            changeWhenClick(txtEmailAddress, txtEmailAddress.Text);
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            changeWhenClick(txtUserName, txtUserName.Text);
        }

        private void txtUserPassword_Click(object sender, EventArgs e)
        {
            changeWhenClick(txtUserPassword, txtUserPassword.Text);
            txtUserPassword.PasswordChar = '*';
        }
       
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtEmailAddress.Text == "" || comboBoxContactAddress.Text == "(Contact address)" || txtUserName.Text == "" || txtUserPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!IsValidEmail(txtEmailAddress.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    String sSQL = "select * from LoginDataTable where userName='" + txtUserName + "'";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Lỗi trùng tài khoản");
                    }
                    else
                    {
                        String anotherStringSQL = "exec ProcUserData N'" + txtFullName.Text + "', '" + txtEmailAddress.Text + "', N'" + comboBoxContactAddress.SelectedValue.ToString() + "', '" + txtUserName.Text + "', '" + txtUserPassword.Text + "'";
                        SqlCommand anotherCmd = new SqlCommand(anotherStringSQL, conn);
                        anotherCmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký tài khoản thành công");
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không kết nối được đến database để kiểm tra tài khoản");
                }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUsernameLogin.Text;
            String password = txtPasswordLogin.Text;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "select * from LoginDataTable where userName='" + userName + "' and userPassword='" + password + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            conn.Close();
        }
    }
}
