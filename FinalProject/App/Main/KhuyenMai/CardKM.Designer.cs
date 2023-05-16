namespace FinalProject.App.Main
{
    partial class CardKM
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
            this.ButtonKM1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel35 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel36 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonKM1
            // 
            this.ButtonKM1.CornerRoundingRadius = 15F;
            this.ButtonKM1.Location = new System.Drawing.Point(898, 98);
            this.ButtonKM1.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonKM1.Name = "ButtonKM1";
            this.ButtonKM1.Size = new System.Drawing.Size(149, 46);
            this.ButtonKM1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.ButtonKM1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.ButtonKM1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonKM1.StateCommon.Border.Rounding = 15F;
            this.ButtonKM1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonKM1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonKM1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonKM1.TabIndex = 13;
            this.ButtonKM1.Values.Text = "Mua ngay";
            // 
            // kryptonLabel35
            // 
            this.kryptonLabel35.AutoSize = false;
            this.kryptonLabel35.Location = new System.Drawing.Point(192, 54);
            this.kryptonLabel35.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel35.Name = "kryptonLabel35";
            this.kryptonLabel35.Size = new System.Drawing.Size(806, 19);
            this.kryptonLabel35.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel35.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kryptonLabel35.TabIndex = 12;
            this.kryptonLabel35.Values.Text = "Áp dụng từ ngày 3/3/2023 đến ngày 3/7/2023 đối với hóa đơn từ 100k";
            // 
            // kryptonLabel36
            // 
            this.kryptonLabel36.Location = new System.Drawing.Point(509, 14);
            this.kryptonLabel36.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel36.Name = "kryptonLabel36";
            this.kryptonLabel36.Size = new System.Drawing.Size(280, 23);
            this.kryptonLabel36.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel36.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel36.TabIndex = 11;
            this.kryptonLabel36.Values.Text = "Nhập mã ANNGON giảm ngay 50%";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::FinalProject.Properties.Resources.HinhKM1;
            this.pictureBox12.Location = new System.Drawing.Point(1, 1);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(171, 152);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            // 
            // CardKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ButtonKM1);
            this.Controls.Add(this.kryptonLabel35);
            this.Controls.Add(this.kryptonLabel36);
            this.Controls.Add(this.pictureBox12);
            this.Name = "CardKM";
            this.Size = new System.Drawing.Size(1056, 156);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton ButtonKM1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel35;
        private Krypton.Toolkit.KryptonLabel kryptonLabel36;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}
