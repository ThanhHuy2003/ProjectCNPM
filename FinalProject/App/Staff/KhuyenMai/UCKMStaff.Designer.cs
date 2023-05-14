﻿namespace FinalProject.App.Staff.KhuyenMai
{
    partial class UCKMStaff
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextbox = new Krypton.Toolkit.KryptonTextBox();
            this.LabelNhapKM = new Krypton.Toolkit.KryptonLabel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 149);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1070, 551);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(75, 91);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(1070, 43);
            this.SearchTextbox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.SearchTextbox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SearchTextbox.StateCommon.Border.Rounding = 30F;
            this.SearchTextbox.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.SearchTextbox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.TabIndex = 10;
            this.SearchTextbox.Text = "Search";
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Leave);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // LabelNhapKM
            // 
            this.LabelNhapKM.Location = new System.Drawing.Point(75, 50);
            this.LabelNhapKM.Margin = new System.Windows.Forms.Padding(2);
            this.LabelNhapKM.Name = "LabelNhapKM";
            this.LabelNhapKM.Size = new System.Drawing.Size(202, 26);
            this.LabelNhapKM.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.LabelNhapKM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhapKM.TabIndex = 12;
            this.LabelNhapKM.Values.Text = "Nhập mã khuyến mãi:";
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.picSearch.Image = global::FinalProject.Properties.Resources.searchh;
            this.picSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSearch.Location = new System.Drawing.Point(1088, 96);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(35, 32);
            this.picSearch.TabIndex = 11;
            this.picSearch.TabStop = false;
            // 
            // UCKMStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.LabelNhapKM);
            this.Name = "UCKMStaff";
            this.Size = new System.Drawing.Size(1220, 750);
            this.Load += new System.EventHandler(this.UCKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonTextBox SearchTextbox;
        private Krypton.Toolkit.KryptonLabel LabelNhapKM;
    }
}
