using FinalProject.App.Admin.TaiKhoan;
using FinalProject.BLL;
using FinalProject.DTO;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin
{
    public partial class UCTK : UserControl
    {
        public UCTK()
        {
            InitializeComponent();
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvTK.DataSource = ehe.getAllUser();
        }
        Form edit = new EditTK();
        private void picSearch_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvTK.DataSource = ehe.searchUser(tbSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            String value = dtgvTK.Rows[rowIndex].Cells[0].Value.ToString();
            ehe.deleteUser(value);
            dtgvTK.DataSource = ehe.getAllUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit.ShowDialog();
            
        }

        bool IsValidEmail(string email)
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            if (IsValidEmail(dtgvTK.Rows[rowIndex].Cells[2].Value.ToString()))
                MessageBox.Show("Invalid Email");
            else
            {
                User newUser = new User();
                newUser.userID = dtgvTK.Rows[rowIndex].Cells[0].Value.ToString();
                newUser.fullName = dtgvTK.Rows[rowIndex].Cells[1].Value.ToString();
                newUser.emailAddress = dtgvTK.Rows[rowIndex].Cells[2].Value.ToString();
                newUser.contactAddress = dtgvTK.Rows[rowIndex].Cells[3].Value.ToString();
                newUser.phoneNumber = dtgvTK.Rows[rowIndex].Cells[4].Value.ToString();
                newUser.userName = dtgvTK.Rows[rowIndex].Cells[5].Value.ToString();
                newUser.userRole = dtgvTK.Rows[rowIndex].Cells[7].Value.ToString();
                if(newUser.userID=="" || newUser.fullName==""|| newUser.emailAddress==""|| newUser.contactAddress==""||newUser.phoneNumber==""|| newUser.userName == "" || newUser.userRole == "")
                {
                    MessageBox.Show("Không được để trống");
                }
                else
                {
                    if (IsValidEmail(newUser.emailAddress)==false)
                        MessageBox.Show("Invalid email");
                    else
                    {
                        ehe.updateUser(newUser);
                        dtgvTK.DataSource = ehe.getAllUser();
                    }
                }
            }
        }


    }
}
