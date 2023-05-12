using FinalProject.App;
using FinalProject.App.Admin;
using FinalProject.App.Login;
using FinalProject.App.Main;
using FinalProject.App.Main.CaiDat;
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

namespace FinalProject
{
    public partial class Main : Form
    {
        Func func = new Func();
        public Main()
        {
            InitializeComponent();
        }
        private void btnTD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTD.Location.Y);
            Func.togglePanel(panel_main, "TD");
        }
        private void btnKM_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            Func.togglePanel(panel_main, "KM");
        }
        private void btnCH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCH.Location.Y);
            Func.togglePanel(panel_main, "CH");
        }
        private void btnGH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnGH.Location.Y);
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTB.Location.Y);
        }
        private void btnCD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCD.Location.Y);
            Func.togglePanel(panel_main, "CD");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Func.togglePanel(panel_main, "Main");
        }
        public class Func
        {
            private static UCTD uCTD;
            private static UCMain uCMain;
            private static UCKM uCKM;
            private static UCCD uCCD;
            private static UCCH uCCH;
            private static UCDN uCDN;
            private static UCDK uCDK;
            private static CardTD cardTD;
            private static CardDH cardDH;
            private static CardKM cardKM;
            private static CardKM2 cardKM2;
            private static UCTK uCTK;
            private static UCKMAdmin uCKMAdmin;
            private static UCDT uCDT;
            private static UCAddKM uCAddKM;
            public static void togglePanel(Panel panel, String panelName)
            {
                panel.Controls.Clear();
                panel.AutoScroll = true;
                switch (panelName)
                {
                    case "Main":
                        if (uCMain == null)
                        {
                            uCMain = new UCMain();
                            panel.Controls.Add(uCMain);
                            uCMain.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCMain.Location = new System.Drawing.Point(0, 0);
                            uCMain.TabIndex = 0;
                            uCMain.AutoScroll = true;
                        }
                        else
                        {
                            panel.Controls.Add(uCMain);
                        }
                        break;
                    case "TD":
                        if (uCTD == null)
                        {
                            uCTD = new UCTD();
                            panel.Controls.Add(uCTD);
                            uCTD.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTD.Location = new System.Drawing.Point(0, 0);
                            uCTD.TabIndex = 0;
                            uCTD.AutoScroll = true;
                        }
                        else
                        {
                            panel.Controls.Add(uCTD);
                        }
                        break;
                    case "KM":
                        if (uCKM == null)
                        {
                            uCKM = new UCKM();
                            panel.Controls.Add(uCKM);
                            uCKM.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCKM.Location = new System.Drawing.Point(0, 0);
                            uCKM.Name = "uCKM";
                            uCKM.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCKM);
                        }
                        break;
                    case "CD":
                        if (uCCD == null)
                        {
                            uCCD = new UCCD();
                            panel.Controls.Add(uCCD);
                            uCCD.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCCD.Location = new System.Drawing.Point(0, 0);
                            uCCD.Name = "uCCD";
                            uCCD.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCCD);
                        }
                        break;
                    case "CH":
                        if (uCCH == null)
                        {
                            uCCH = new UCCH();
                            panel.Controls.Add(uCCH);
                            uCCH.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCCH.Location = new System.Drawing.Point(0, 0);
                            uCCH.Name = "uCCH";
                            uCCH.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCCH);
                        }
                        break;
                    case "DN":

                        uCDN = new UCDN();
                        panel.Controls.Add(uCDN);
                        uCDN.Dock = System.Windows.Forms.DockStyle.Fill;
                        uCDN.Location = new System.Drawing.Point(0, 0);
                        uCDN.Name = "uCDN";
                        uCDN.TabIndex = 0;
                        break;
                    case "DK":
                        uCDK = new UCDK();
                        panel.Controls.Add(uCDK);
                        uCDK.Dock = System.Windows.Forms.DockStyle.Fill;
                        uCDK.Location = new System.Drawing.Point(0, 0);
                        uCDK.Name = "uCDK";
                        uCDK.TabIndex = 0;
                        break;
                    case "CardTD":
                        if (cardTD == null)
                        {
                            cardTD = new CardTD();
                            panel.Controls.Add(cardTD);
                            cardTD.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardTD.Location = new System.Drawing.Point(0, 0);
                            cardTD.Name = "cardTD";
                            cardTD.TabIndex = 0;
                            cardTD.AutoScroll = true;
                        }
                        else
                        {
                            panel.Controls.Add(cardTD);
                        }
                        break;
                    case "CardDH":
                        if (cardDH == null)
                        {
                            cardDH = new CardDH();
                            panel.Controls.Add(cardDH);
                            cardDH.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardDH.Location = new System.Drawing.Point(0, 0);
                            cardDH.Name = "cardDH";
                        }
                        else
                        {
                            panel.Controls.Add(cardDH);
                        }
                        break;
                    case "CardKM":
                        if (cardKM == null)
                        {
                            cardKM = new CardKM();
                            panel.Controls.Add(cardKM);
                            cardKM.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardKM.Location = new System.Drawing.Point(0, 0);
                            cardKM.Name = "cardKM";
                        }
                        else
                        {
                            panel.Controls.Add(cardKM);
                        }
                        break;
                    case "CardKM2":
                        if (cardKM == null)
                        {
                            cardKM2 = new CardKM2();
                            panel.Controls.Add(cardKM2);
                            cardKM2.Dock = System.Windows.Forms.DockStyle.Fill;
                            cardKM2.Location = new System.Drawing.Point(0, 0);
                            cardKM2.Name = "cardKM";
                        }
                        else
                        {
                            panel.Controls.Add(cardKM2);
                        }
                        break;
                    case "TK":
                        if (uCTK == null)
                        {
                            uCTK = new UCTK();
                            panel.Controls.Add(uCTK);
                            uCTK.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTK.Location = new System.Drawing.Point(0, 0);
                            uCTK.Name = "uCTK";
                            uCTK.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTK);
                        }
                        break;
                    case "KMAdmin":
                        if (uCKMAdmin == null)
                        {
                            uCKMAdmin = new UCKMAdmin();
                            panel.Controls.Add(uCKMAdmin);
                            uCKMAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCKMAdmin.Location = new System.Drawing.Point(0, 0);
                            uCKMAdmin.Name = "uCKMAdmin";
                            uCKMAdmin.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Clear();
                            panel.Controls.Add(uCKMAdmin);
                        }
                        break;
                    case "DT":
                        if (uCDT == null)
                        {
                            uCDT = new UCDT();
                            panel.Controls.Add(uCDT);
                            uCDT.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCDT.Location = new System.Drawing.Point(0, 0);
                            uCDT.Name = "uCDT";
                            uCDT.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCDT);
                        }
                        break;
                    case "AddKM":
                        if (uCAddKM == null)
                        {
                            uCAddKM = new UCAddKM();
                            panel.Controls.Add(uCAddKM);
                            uCAddKM.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCAddKM.Location = new System.Drawing.Point(0, 0);
                            uCAddKM.Name = "uCAddKM";
                            uCAddKM.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCAddKM);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
