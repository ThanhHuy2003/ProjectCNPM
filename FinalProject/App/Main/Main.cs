using FinalProject.App;
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

namespace FinalProject
{
    public partial class Main : Form
    {
        Func func = new Func();
        public Main()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void btnTD_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnTD.Location.Y);
            Func.togglePanel(this, panel_main, "TD");
        }
        private void btnKM_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            Func.togglePanel(this, panel_main, "KM");
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCH.Location.Y);
            Func.togglePanel(this, panel_main, "CH");
        }

        private void btnGH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnGH.Location.Y);
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Func.togglePanel(this, panel_main, "CD");
        }
        int mov;
        int movX;
        int movY;
        private void kryptonPanel18_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void kryptonPanel18_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void kryptonPanel18_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Func.togglePanel(this, panel_main, "Main");
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
            public static void togglePanel(Form form,Panel panel,String panelName)
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
                            form.Size = new System.Drawing.Size(1550, 900);
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
                            form.Size = new System.Drawing.Size(1550, 900);
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
                            form.Size = new System.Drawing.Size(1550, 900);
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
                            form.Size = new System.Drawing.Size(1550, 900);
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
                            form.Size = new System.Drawing.Size(1550, 900);
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
                            form.Size = new System.Drawing.Size(1100, 750);
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
                    default:
                        break;
                }
            }
        }
        
/*        public void togglePanelMain(String panelName)
        {
            this.panel_main.Controls.Clear();
            this.panel_main.AutoScroll= true;
            switch (panelName)
            {
                case "TD":
                    if(this.uCTD == null)
                    {
                        this.uCTD= new UCTD();
                        this.panel_main.Controls.Add(uCTD);
                        this.uCTD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCTD.Location = new System.Drawing.Point(0, 0);
                        this.uCTD.Name = "uCTD";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.uCTD.TabIndex = 0;
                        this.uCTD.AutoScroll= true;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCTD);
                    }
                    break;
                case "Main":
                    if (this.uCMain == null)
                    {
                        this.uCMain = new UCMain();
                        this.panel_main.Controls.Add(uCMain);
                        this.uCMain.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCMain.Name = "uCMain";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.uCMain.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCMain);
                    }
                    break;
                case "KM":
                    if (this.uCKM == null)
                    {
                        this.uCKM = new UCKM();
                        this.panel_main.Controls.Add(uCKM);
                        this.uCKM.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCKM.Name = "uCKM";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.uCKM.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCKM);
                    }
                    break;
                case "CD":
                    if (this.uCCD == null)
                    {
                        this.uCCD = new UCCD();
                        this.panel_main.Controls.Add(uCCD);
                        this.uCCD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCD.Name = "uCCD";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.uCCD.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCCD);
                    }
                    break;
                case "CH":
                    if (this.uCCH == null)
                    {
                        this.uCCH = new UCCH();
                        this.panel_main.Controls.Add(uCCH);
                        this.uCCH.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCH.Name = "uCCH";
                        this.Size = new System.Drawing.Size(1200, 800);
                        this.uCCH.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCCH);
                    }
                    break;
                default:
                    break;
            }
        }
*/        



        
        


    }
}
