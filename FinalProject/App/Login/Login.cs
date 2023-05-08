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

namespace FinalProject.App.Login
{
    public partial class Login : Form
    {
        public static String name = "DN";
        public Login()
        {
            InitializeComponent();
        }
        private UCDN uCDN;
        private void Login2_Load(object sender, EventArgs e)
        {
            Func.togglePanel(panel_login, name);
            MinimizeBox = false;
            MaximizeBox= false;
        }
    }
}
