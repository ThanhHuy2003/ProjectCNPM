using FinalProject.App;
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
            this.togglePanelMain("TD");
        }
        private void btnKM_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnKM.Location.Y);
            this.togglePanelMain("KM");
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            menu_active.Visible = true;
            this.menu_active.Location = new Point(1, btnCH.Location.Y);
            this.togglePanelMain("CH");
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
            this.togglePanelMain("CD");
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

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }
        
        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
        }

        

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.togglePanelMain("Main");
        }

        private UCTD uCTD;
        private UCMain uCMain;
        private UCKM uCKM;
        private UCCD uCCD;
        private UCCH uCCH;
        public void togglePanelMain(String panelName)
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
        



        
        


    }
}
