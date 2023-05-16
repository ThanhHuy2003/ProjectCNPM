namespace FinalProject.App.Main.KhuyenMai
{
    partial class CardKMForDisplay
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
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel35 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel36 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::FinalProject.Properties.Resources.HinhKM1;
            this.pictureBox12.Location = new System.Drawing.Point(3, 2);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(228, 187);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // kryptonLabel35
            // 
            this.kryptonLabel35.AutoSize = false;
            this.kryptonLabel35.Location = new System.Drawing.Point(256, 66);
            this.kryptonLabel35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel35.Name = "kryptonLabel35";
            this.kryptonLabel35.Size = new System.Drawing.Size(1075, 23);
            this.kryptonLabel35.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel35.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kryptonLabel35.TabIndex = 13;
            this.kryptonLabel35.Values.Text = "Áp dụng từ ngày 3/3/2023 đến ngày 3/7/2023 đối với hóa đơn từ 100k";
            // 
            // kryptonLabel36
            // 
            this.kryptonLabel36.Location = new System.Drawing.Point(679, 17);
            this.kryptonLabel36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel36.Name = "kryptonLabel36";
            this.kryptonLabel36.Size = new System.Drawing.Size(349, 28);
            this.kryptonLabel36.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel36.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel36.TabIndex = 14;
            this.kryptonLabel36.Values.Text = "Nhập mã ANNGON giảm ngay 50%";
            // 
            // CardKMForDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonLabel36);
            this.Controls.Add(this.kryptonLabel35);
            this.Controls.Add(this.pictureBox12);
            this.Name = "CardKMForDisplay";
            this.Size = new System.Drawing.Size(1408, 192);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox12;
        private Krypton.Toolkit.KryptonLabel kryptonLabel35;
        private Krypton.Toolkit.KryptonLabel kryptonLabel36;
    }
}
