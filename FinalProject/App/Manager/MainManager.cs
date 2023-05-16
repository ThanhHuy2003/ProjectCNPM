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

namespace FinalProject.App.Manager
{
    public partial class MainManager : Form
    {
        public MainManager()
        {
            InitializeComponent();
            Func.togglePanel(pnlManager, "NV");

        }
        Func Func;
        private void btnNV_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "NV");
        }

        private void MainManager_Load(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "NV");
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            Func.togglePanel(pnlManager, "Luong");
        }

        private void btnTB_Click(object sender, EventArgs e)
        {

        }
    }
}
