using FinalProject.App.Main.CaiDat;
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

namespace FinalProject.App.Main.CaiDat
{
    public partial class UCCD : UserControl
    {
        public UCCD()
        {
            InitializeComponent();
        }
        Func Func;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                btnLS.Select();
                Func.togglePanel(panelDH, "CardDH");
            }
        }
    }
}
