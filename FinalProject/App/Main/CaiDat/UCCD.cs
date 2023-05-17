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
            InitializeComponent();
        }
        Func Func = new Func();
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
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
    }
}
