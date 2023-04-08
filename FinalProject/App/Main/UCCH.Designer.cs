namespace FinalProject.App
{
    partial class UCCH
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCH = new Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenCN = new Krypton.Toolkit.KryptonLabel();
            this.lblDc = new Krypton.Toolkit.KryptonLabel();
            this.lblGMC = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCH
            // 
            this.lblCH.Location = new System.Drawing.Point(50, 25);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(427, 36);
            this.lblCH.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCH.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH.TabIndex = 0;
            this.lblCH.Values.Text = "Các cửa hàng tại TP.Hồ Chí Minh";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(924, -31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenCN
            // 
            this.lblTenCN.Location = new System.Drawing.Point(246, 25);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(292, 36);
            this.lblTenCN.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTenCN.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCN.TabIndex = 3;
            this.lblTenCN.Values.Text = "Lotteria Nam Sài Gòn";
            // 
            // lblDc
            // 
            this.lblDc.Location = new System.Drawing.Point(246, 80);
            this.lblDc.Name = "lblDc";
            this.lblDc.Size = new System.Drawing.Size(786, 24);
            this.lblDc.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblDc.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDc.TabIndex = 4;
            this.lblDc.Values.Text = "Địa chỉ : Lotte Nam Sài Gòn, Nguyễn Thị Thập, phường Tân Phong, quận 7, Thành phố" +
    " Hồ Chí Minh";
            // 
            // lblGMC
            // 
            this.lblGMC.Location = new System.Drawing.Point(246, 129);
            this.lblGMC.Name = "lblGMC";
            this.lblGMC.Size = new System.Drawing.Size(204, 24);
            this.lblGMC.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblGMC.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMC.TabIndex = 5;
            this.lblGMC.Values.Text = "Giờ mở cửa: 8:00 - 21:00";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblTenCN);
            this.kryptonPanel1.Controls.Add(this.lblGMC);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Controls.Add(this.lblDc);
            this.kryptonPanel1.Location = new System.Drawing.Point(83, 113);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1107, 210);
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.Silver;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // UCCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.lblCH);
            this.Name = "UCCH";
            this.Size = new System.Drawing.Size(1235, 776);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblCH;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblTenCN;
        private Krypton.Toolkit.KryptonLabel lblDc;
        private Krypton.Toolkit.KryptonLabel lblGMC;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
