namespace FinalProject.App.Main.ThucDon
{
    partial class CardTD
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
            this.lblVND = new Krypton.Toolkit.KryptonLabel();
            this.btnTTN = new Krypton.Toolkit.KryptonButton();
            this.btnTVG = new Krypton.Toolkit.KryptonButton();
            this.lblPrice = new Krypton.Toolkit.KryptonLabel();
            this.SubItem1 = new Krypton.Toolkit.KryptonButton();
            this.PlusItem1 = new Krypton.Toolkit.KryptonButton();
            this.CountItem1 = new Krypton.Toolkit.KryptonLabel();
            this.lblName = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVND
            // 
            this.lblVND.Location = new System.Drawing.Point(193, 230);
            this.lblVND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(79, 40);
            this.lblVND.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.lblVND.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Italic);
            this.lblVND.TabIndex = 38;
            this.lblVND.Values.Text = "VND";
            // 
            // btnTTN
            // 
            this.btnTTN.CornerRoundingRadius = 30F;
            this.btnTTN.Location = new System.Drawing.Point(175, 318);
            this.btnTTN.Margin = new System.Windows.Forms.Padding(4);
            this.btnTTN.Name = "btnTTN";
            this.btnTTN.Size = new System.Drawing.Size(157, 42);
            this.btnTTN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnTTN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnTTN.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTTN.StateCommon.Border.Rounding = 30F;
            this.btnTTN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTTN.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTN.TabIndex = 37;
            this.btnTTN.Values.Text = "Thanh toán ngay";
            this.btnTTN.Click += new System.EventHandler(this.btnTTN_Click);
            // 
            // btnTVG
            // 
            this.btnTVG.CornerRoundingRadius = 30F;
            this.btnTVG.Location = new System.Drawing.Point(1, 318);
            this.btnTVG.Margin = new System.Windows.Forms.Padding(4);
            this.btnTVG.Name = "btnTVG";
            this.btnTVG.Size = new System.Drawing.Size(157, 42);
            this.btnTVG.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnTVG.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnTVG.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTVG.StateCommon.Border.Rounding = 30F;
            this.btnTVG.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTVG.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTVG.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVG.TabIndex = 36;
            this.btnTVG.Values.Text = "Thêm vào giỏ";
            this.btnTVG.Click += new System.EventHandler(this.btnTVG_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(41, 230);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(118, 40);
            this.lblPrice.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.lblPrice.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Italic);
            this.lblPrice.TabIndex = 35;
            this.lblPrice.Values.Text = "100,000";
            // 
            // SubItem1
            // 
            this.SubItem1.CornerRoundingRadius = -1F;
            this.SubItem1.Location = new System.Drawing.Point(87, 274);
            this.SubItem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubItem1.Name = "SubItem1";
            this.SubItem1.Size = new System.Drawing.Size(49, 38);
            this.SubItem1.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.SubItem1.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.SubItem1.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.SubItem1.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.SubItem1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubItem1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubItem1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.SubItem1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.SubItem1.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.SubItem1.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.SubItem1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubItem1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.SubItem1.TabIndex = 34;
            this.SubItem1.Values.Text = "-";
            this.SubItem1.Click += new System.EventHandler(this.SubItem1_Click);
            // 
            // PlusItem1
            // 
            this.PlusItem1.CornerRoundingRadius = -1F;
            this.PlusItem1.Location = new System.Drawing.Point(193, 274);
            this.PlusItem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlusItem1.Name = "PlusItem1";
            this.PlusItem1.Size = new System.Drawing.Size(49, 38);
            this.PlusItem1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.PlusItem1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.PlusItem1.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.PlusItem1.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.PlusItem1.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.PlusItem1.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.PlusItem1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PlusItem1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusItem1.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.PlusItem1.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.PlusItem1.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.PlusItem1.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.PlusItem1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PlusItem1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusItem1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.PlusItem1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.PlusItem1.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.PlusItem1.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.PlusItem1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PlusItem1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.PlusItem1.TabIndex = 33;
            this.PlusItem1.Values.Text = "+";
            this.PlusItem1.Click += new System.EventHandler(this.PlusItem1_Click);
            // 
            // CountItem1
            // 
            this.CountItem1.Location = new System.Drawing.Point(155, 274);
            this.CountItem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountItem1.Name = "CountItem1";
            this.CountItem1.Size = new System.Drawing.Size(24, 39);
            this.CountItem1.StateCommon.ShortText.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountItem1.TabIndex = 31;
            this.CountItem1.Values.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.Location = new System.Drawing.Point(41, 186);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 39);
            this.lblName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblName.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.TabIndex = 32;
            this.lblName.Values.Text = "Gà rán";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FinalProject.Properties.Resources.image_1;
            this.pictureBox9.Location = new System.Drawing.Point(1, 5);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(255, 143);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            // 
            // CardTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.btnTTN);
            this.Controls.Add(this.btnTVG);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.SubItem1);
            this.Controls.Add(this.PlusItem1);
            this.Controls.Add(this.CountItem1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CardTD";
            this.Size = new System.Drawing.Size(343, 366);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblVND;
        private Krypton.Toolkit.KryptonButton btnTTN;
        private Krypton.Toolkit.KryptonButton btnTVG;
        private Krypton.Toolkit.KryptonLabel lblPrice;
        private Krypton.Toolkit.KryptonButton SubItem1;
        private Krypton.Toolkit.KryptonButton PlusItem1;
        private Krypton.Toolkit.KryptonLabel CountItem1;
        private Krypton.Toolkit.KryptonLabel lblName;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
