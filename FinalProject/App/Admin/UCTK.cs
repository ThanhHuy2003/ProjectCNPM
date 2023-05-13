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

        private void picSearch_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvTK.DataSource = ehe.searchUser(tbSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            int columnIndex = dtgvTK.SelectedCells[0].ColumnIndex;
            String value = dtgvTK.Rows[rowIndex].Cells[columnIndex].Value.ToString();
            ehe.deleteUser(value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            User newUser = new User();
            if (dtgvTK.Rows[rowIndex].Cells[1].Value == null || dtgvTK.Rows[rowIndex].Cells[2].Value == null || dtgvTK.Rows[rowIndex].Cells[3].Value == null || dtgvTK.Rows[rowIndex].Cells[4].Value == null || dtgvTK.Rows[rowIndex].Cells[5].Value == null || dtgvTK.Rows[rowIndex].Cells[6].Value == null || dtgvTK.Rows[rowIndex].Cells[7].Value == null)
                MessageBox.Show("Nhap thieu kia");
            else
            {
                newUser.fullName = dtgvTK.Rows[rowIndex].Cells[1].Value.ToString();
                newUser.emailAddress = dtgvTK.Rows[rowIndex].Cells[2].Value.ToString();
                newUser.contactAddress = dtgvTK.Rows[rowIndex].Cells[3].Value.ToString();
                newUser.phoneNumber = dtgvTK.Rows[rowIndex].Cells[4].Value.ToString();
                newUser.userName = dtgvTK.Rows[rowIndex].Cells[5].Value.ToString();
                newUser.userPassword = dtgvTK.Rows[rowIndex].Cells[6].Value.ToString();
                newUser.userRole = dtgvTK.Rows[rowIndex].Cells[7].Value.ToString();
                ehe.addUser(newUser);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            User newUser = new User();
            newUser.userID = dtgvTK.Rows[rowIndex].Cells[0].Value.ToString();
            newUser.fullName = dtgvTK.Rows[rowIndex].Cells[1].Value.ToString();
            newUser.emailAddress = dtgvTK.Rows[rowIndex].Cells[2].Value.ToString();
            newUser.contactAddress = dtgvTK.Rows[rowIndex].Cells[3].Value.ToString();
            newUser.phoneNumber = dtgvTK.Rows[rowIndex].Cells[4].Value.ToString();
            newUser.userName = dtgvTK.Rows[rowIndex].Cells[5].Value.ToString();
            newUser.userPassword = dtgvTK.Rows[rowIndex].Cells[6].Value.ToString();
            newUser.userRole = dtgvTK.Rows[rowIndex].Cells[7].Value.ToString();
            ehe.updateUser(newUser);
        }


    }
}
