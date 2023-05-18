using FinalProject.App.Main.CaiDat;
using FinalProject.BLL;
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
using static FinalProject.Main;

namespace FinalProject.App.Main.CaiDat
{
    public partial class UCCD : UserControl
    {
        public UCCD()
        {
            File ehe = new File();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ehe.readLanguage());
            InitializeComponent();
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

        private void tabTTCN_Click(object sender, EventArgs e)
        {

        }

        private void btnSighOut_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CBQQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblQQ_Click(object sender, EventArgs e)
        {

        }

        private void lblNS_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSDT_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNS_Click(object sender, EventArgs e)
        {

        }

        private void txtNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelHoten_Click(object sender, EventArgs e)
        {

        }

        private void tabDH_Click(object sender, EventArgs e)
        {

        }

        private void panelDH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDHHT_Click(object sender, EventArgs e)
        {

        }

        private void btnLS_Click(object sender, EventArgs e)
        {

        }

        private void tabPTTT_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radbtnMoney_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radbtnMomo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabBMDK_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
