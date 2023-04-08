using FinalProject.App.Main.ThucDon;
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
    public partial class UCTD : UserControl
    {
        public UCTD()
        {
            InitializeComponent();
        }

        private void UCTD_Load(object sender, EventArgs e)
        {
            togglePanelMain("Card");
        }
        private CardTD cardTD;

        public void togglePanelMain(String panelName)
        {
            this.panelCard.Controls.Clear();
            this.panelCard.AutoScroll = true;
            switch (panelName)
            {
                case "Card":
                    if (this.cardTD == null)
                    {
                        this.cardTD = new CardTD();
                        this.panelCard.Controls.Add(cardTD);
                        this.cardTD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.cardTD.Location = new System.Drawing.Point(0, 0);
                        this.cardTD.Name = "cardTD";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.cardTD.TabIndex = 0;
                        this.cardTD.AutoScroll = true;
                    }
                    else
                    {
                        this.panelCard.Controls.Add(cardTD);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
