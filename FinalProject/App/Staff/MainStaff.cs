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

namespace FinalProject.App.Staff
{
    public partial class MainStaff : Form
    {
        private string userIDLogin;
        Func Func = new Func();
        public MainStaff()
        {
            InitializeComponent();
            Func.togglePanel(pnlMainStaff, "TDStaff");
        }
        public MainStaff(string userIDLogin)
        {
            InitializeComponent();
            Func.togglePanel(pnlMainStaff, "TDStaff");
            this.userIDLogin = userIDLogin;
        }
        private void btnTD_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlMainStaff, "TDStaff");
        }

        private void MainStaff_Load(object sender, EventArgs e)
        {
            btnlogo.Select();
            Func.togglePanel(pnlMainStaff, "TDStaff");
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlMainStaff, "KMStaff");
        }
    }
}
