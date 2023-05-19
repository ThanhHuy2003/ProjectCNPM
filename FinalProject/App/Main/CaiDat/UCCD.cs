using FinalProject.App.Main.CaiDat;
using FinalProject.BLL;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.MainUser;

namespace FinalProject.App.Main.CaiDat
{
    public partial class UCCD : UserControl
    {
        private String id;
        public UCCD(string id)
        {
            File ehe = new File();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ehe.readLanguage());
            InitializeComponent();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            ProvinceBLL storeBLL = new ProvinceBLL();
            foreach (DataRow row in storeBLL.getAllProvince().Rows)
            {
                comboSource.Add(row["provinceID"].ToString(), row["provinceName"].ToString());
            }
            CBQQ.DataSource = new BindingSource(comboSource, null);
            CBQQ.DisplayMember = "Value";
            CBQQ.ValueMember = "Key";
            this.id = id;
        }
        Func Func= new Func();
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                label13.Select();
                Func.togglePanel(panelDH, "CardDH");
            }
        }
        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            File ehe = new File();
            switch (kryptonComboBox1.SelectedIndex)
            {
                case 0:
                    ehe.changeLanguage("vi");
                    MessageBox.Show("Khởi động lại ứng đụng để cập nhập cài đặt");
                    InitializeComponent();
                    break;
                case 1:
                    ehe.changeLanguage("en");
                    MessageBox.Show("Khởi động lại ứng đụng để cập nhập cài đặt");
                    InitializeComponent();
                    break;
            }
        }
        private void UCCD_Load(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            User user = new User();
            user = ehe.getUserByID(this.id);
            txtHoten.Text = user.fullName;
            txtEmail.Text = user.emailAddress;
            txtNS.Text = user.userDateOfBirth;
            txtSDT.Text = user.phoneNumber;
            CBQQ.SelectedIndex = CBQQ.FindStringExact(user.contactAddress);
        }
        private void btnSighOut_Click(object sender, EventArgs e)
        {

        }

        private void CBQQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.userID=this.id;
            newUser.fullName=txtHoten.Text;
            newUser.userDateOfBirth = txtNS.Text;
            newUser.phoneNumber = txtSDT.Text;
            newUser.emailAddress = txtEmail.Text;
            MessageBox.Show(CBQQ);
            /*newUser.contactAddress = CBQQ.SelectedValue.Text;*/
            AdminUserBLL userBLL = new AdminUserBLL();
            userBLL.updateUser(newUser);
            this.tabTTCN.Refresh();
        }

        private void btnSDT_Click(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            btnSave.Enabled = true;
        }


        private void btnEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled= true;
            btnSave.Enabled = true;
        }


        private void btnNS_Click(object sender, EventArgs e)
        {
            txtNS.Enabled= true;
            btnSave.Enabled = true;
        }


        private void btnHoTen_Click(object sender, EventArgs e)
        {
            txtHoten.Enabled = true;
            btnSave.Enabled = true;
        }

        private void radbtnMoney_CheckedChanged(object sender, EventArgs e)
        {

        }
      
        private void radbtnMomo_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
