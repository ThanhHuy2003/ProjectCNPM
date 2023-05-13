using FinalProject.App.Admin.KhuyenMai;
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
using static FinalProject.Main;

namespace FinalProject.App.Admin
{
    public partial class UCKMAdmin : UserControl
    {
        MainAdmin main = new MainAdmin();
        public UCKMAdmin()
        {
            InitializeComponent();
        }
        Form frm  = new AddKM();

        private void btnAddKM_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }

    }
}
