using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.ThongBao
{
    public partial class CardTB : UserControl
    {
        Form frm = new TBDetail();
        public CardTB()
        {
            InitializeComponent();
        }

        private void lblChitiet_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }
    }
}
