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
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }
        Func Func;
        private void MainAdmin_Load(object sender, EventArgs e)
        {
            Func.togglePanel(pnlAdmin, "TK");
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            
            Func.togglePanel(pnlAdmin, "KMAdmin");
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlAdmin, "TBAdmin");
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlAdmin, "DT");
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlAdmin, "TK");
        }
    }
}
