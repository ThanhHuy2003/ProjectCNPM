using FinalProject.BLL;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject.App.Admin.TaiKhoan
{
    public partial class EditTK : Form
    {
        public EditTK()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           AdminUserBLL ehe = new AdminUserBLL();
           User newUser = new User();
           if(txtFullname.Text=="" || txtEmail.Text==""||txtPassword.Text==""||txtPhonenumber.Text==""||txtUsername.Text=="")
               MessageBox.Show("Nhap thieu kia");
           else
           {
               newUser.fullName = txtFullname.Text;
               newUser.emailAddress = txtEmail.Text;
               newUser.contactAddress = cbAddress.SelectedText;
               newUser.phoneNumber = txtPhonenumber.Text;
               newUser.userName = txtUsername.Text;
               newUser.userRole = cbRole.SelectedText;
               ehe.addUser(newUser);
           }
        }

        private void EditTK_Load(object sender, EventArgs e)
        {
            AdminRevenueBLL ehe = new AdminRevenueBLL();
            Dictionary<string, string> comboSourc = new Dictionary<string, string>();
            StoreAddressTableBLL storeBLL = new StoreAddressTableBLL();
            foreach (DataRow row in storeBLL.populateStoreAddressData_StoreAddressTable_BLL().Rows)
            {
                comboSourc.Add(row["storeID"].ToString(), row["storeName"].ToString());
            }
            cbAddress.DataSource = new BindingSource(comboSourc, null);
            cbAddress.DisplayMember = "Value";
            cbAddress.ValueMember = "Key";
        }
    }
}
