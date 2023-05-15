using FinalProject.App;
using FinalProject.App.Admin;
using FinalProject.App.Admin.ThongBao;
using FinalProject.App.Login;
using FinalProject.App.Main;
using FinalProject.App.Main.CaiDat;
using FinalProject.App.Main.GioHang;
using FinalProject.App.Main.ThucDon;
using FinalProject.App.Staff.GioHang;
using FinalProject.App.Staff.KhuyenMai;
using FinalProject.App.Staff.ThucDon;
using FinalProject.DTO;
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
        private string userIDLogin; 
        Func func;
        public Main()
        {
            InitializeComponent();
            func = new Func(this);
        }
        public Main(string userIDLogin)
        {
            InitializeComponent();
            func = new Func(this);
            this.userIDLogin = userIDLogin;
        }
        private void btnTD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTD.Location.Y);
            func.togglePanel(panel_main, "TD");
        }
        private void btnKM_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            func.togglePanel(panel_main, "KM");
        }
        private void btnCH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCH.Location.Y);
            func.togglePanel(panel_main, "CH");
        }
        private void btnGH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnGH.Location.Y);
            func.togglePanel(panel_main, "GH");
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTB.Location.Y);
            func.togglePanel(panel_main, "TB");
        }
        private void btnCD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCD.Location.Y);
            func.togglePanel(panel_main, "CD");
        }
        private void btnlogo_Click(object sender, EventArgs e)
        {
            func.togglePanel(panel_main, "Main");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            btnlogo.Select();
            func.togglePanel(panel_main, "Main");
        }
        public class Func
        {

            private Main main;
            public Func(Main main)
            {
                this.main = main;
            }
            //User
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
            //Admin
            private static UCTK uCTK;
            private static UCKMAdmin uCKMAdmin;
            private static UCDT uCDT;
            private static UCTBAdmin uCTBAdmin;
            private static UCTB uCTB;
            //Staff
            private static UCTDStaff uCTDStaff;
            private static UCKMStaff uCKMStaff;
            private static UCGH uCGH;
            public void togglePanel(Panel panel, String panelName)
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
                    case "TB":
                        if (uCTB == null)
                        {
                            uCTB = new UCTB();
                            panel.Controls.Add(uCTB);
                            uCTB.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTB.Location = new System.Drawing.Point(0, 0);
                            uCTB.Name = "uCTB";
                            uCTB.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTB);
                        }
                        break;
                    case "GH":
                        if (uCGH == null)
                        {
                            uCGH = new UCGH(main.userIDLogin);
                            panel.Controls.Add(uCGH);
                            uCGH.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCGH.Location = new System.Drawing.Point(0, 0);
                            uCGH.Name = "uCGH";
                            uCGH.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCGH);
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
                    case "TBAdmin":
                        if (uCTBAdmin == null)
                        {
                            uCTBAdmin = new UCTBAdmin();
                            panel.Controls.Add(uCTBAdmin);
                            uCTBAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTBAdmin.Location = new System.Drawing.Point(0, 0);
                            uCTBAdmin.Name = "uCTBAdmin";
                            uCTBAdmin.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTBAdmin);
                        }
                        break;
                    case "TDStaff":
                        if (uCTDStaff == null)
                        {
                            uCTDStaff = new UCTDStaff();
                            panel.Controls.Add(uCTBAdmin);
                            uCTDStaff.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCTDStaff.Location = new System.Drawing.Point(0, 0);
                            uCTDStaff.Name = "uCTDStaff";
                            uCTDStaff.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCTDStaff);
                        }
                        break;
                    case "KMStaff":
                        if (uCKMStaff == null)
                        {
                            uCKMStaff = new UCKMStaff();
                            panel.Controls.Add(uCTBAdmin);
                            uCKMStaff.Dock = System.Windows.Forms.DockStyle.Fill;
                            uCKMStaff.Location = new System.Drawing.Point(0, 0);
                            uCKMStaff.Name = "uCKMStaff";
                            uCKMStaff.TabIndex = 0;
                        }
                        else
                        {
                            panel.Controls.Add(uCKMStaff);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        
    }
}
