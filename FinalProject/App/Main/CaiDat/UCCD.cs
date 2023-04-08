using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App
{
    public partial class UCCD : UserControl
    {
        public UCCD()
        {
            InitializeComponent();
        }

        private void picSA_Click(object sender, EventArgs e)
        {
        }

        
        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            togglePanelMain("TTCN");
        }
        private UCTTCN uCTTCN;
        internal void togglePanelMain(String panelName)
        {
            this.panelCD.BringToFront();
            this.panelCD.Controls.Clear();
            switch (panelName)
            {
                case "TTCN":
                    if (this.uCTTCN == null)
                    {
                        this.uCTTCN = new UCTTCN();
                        this.panelCD.Controls.Add(uCTTCN);
                        this.uCTTCN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCTTCN.Location = new System.Drawing.Point(1, 1);
                        this.uCTTCN.Name = "uCTD";
                        this.panelCD.Size = new System.Drawing.Size(1200, 800);
                        this.uCTTCN.TabIndex = 0;
                        this.uCTTCN.AutoScroll = true;
                    }
                    else
                    {
                        this.panelCD.Controls.Add(uCTTCN);
                    }
                    break;
               
                default:
                    break;
            }
        }
    }
}
