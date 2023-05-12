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
        private UCKMAdmin uCKMAdmin;
        public UCKMAdmin()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            pnlAddKM.Visible = true;
            pnlAddKM.Size = new System.Drawing.Size(1080, 800);
            pnlAddKM.Location = new System.Drawing.Point(0, 0);
            Func.togglePanel(pnlAddKM, "AddKM");
            main.Controls.Remove(uCKMAdmin);
        }

        private void UCKMAdmin_Load(object sender, EventArgs e)
        {
            pnlAddKM.Visible = false;
        }
    }
}
