namespace FinalProject.App.Admin.ThongBao
{
    partial class CardTBAdmin
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
            this.picTB = new System.Windows.Forms.PictureBox();
            this.lblTB = new Krypton.Toolkit.KryptonLabel();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTB)).BeginInit();
            this.SuspendLayout();
            // 
            // picTB
            // 
            this.picTB.Image = global::FinalProject.Properties.Resources.HinhKM1;
            this.picTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picTB.Location = new System.Drawing.Point(0, 2);
            this.picTB.Margin = new System.Windows.Forms.Padding(2);
            this.picTB.Name = "picTB";
            this.picTB.Size = new System.Drawing.Size(171, 152);
            this.picTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTB.TabIndex = 15;
            this.picTB.TabStop = false;
            // 
            // lblTB
            // 
            this.lblTB.Location = new System.Drawing.Point(191, 15);
            this.lblTB.Margin = new System.Windows.Forms.Padding(2);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(544, 23);
            this.lblTB.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTB.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.TabIndex = 16;
            this.lblTB.Values.Text = "Bạn vừa nhận được ưu đãi mới lên đến 50% khi mua hóa đơn trên 200k";
            // 
            // btnDelete
            // 
            this.btnDelete.CornerRoundingRadius = 30F;
            this.btnDelete.Location = new System.Drawing.Point(742, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 46);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnDelete.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 30F;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Values.Text = "Xóa";
            // 
            // btnEdit
            // 
            this.btnEdit.CornerRoundingRadius = 30F;
            this.btnEdit.Location = new System.Drawing.Point(587, 108);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 46);
            this.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnEdit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnEdit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnEdit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnEdit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEdit.StateCommon.Border.Rounding = 30F;
            this.btnEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Values.Text = "Chỉnh Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // CardTBAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.picTB);
            this.Name = "CardTBAdmin";
            this.Size = new System.Drawing.Size(907, 164);
            ((System.ComponentModel.ISupportInitialize)(this.picTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTB;
        private Krypton.Toolkit.KryptonLabel lblTB;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnEdit;
    }
}
