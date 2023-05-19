namespace FinalProject.App
{
    partial class UCKM
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
            this.LabelNhapKM = new Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextbox = new Krypton.Toolkit.KryptonTextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNhapKM
            // 
            this.LabelNhapKM.Location = new System.Drawing.Point(96, 52);
            this.LabelNhapKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelNhapKM.Name = "LabelNhapKM";
            this.LabelNhapKM.Size = new System.Drawing.Size(194, 31);
            this.LabelNhapKM.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.LabelNhapKM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhapKM.TabIndex = 7;
            this.LabelNhapKM.Values.Text = "Tìm khuyến mãi:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 174);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1570, 809);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(96, 102);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(1427, 47);
            this.SearchTextbox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.SearchTextbox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SearchTextbox.StateCommon.Border.Rounding = 30F;
            this.SearchTextbox.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.SearchTextbox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.TabIndex = 6;
            this.SearchTextbox.Text = "Search";
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.picSearch.Image = global::FinalProject.Properties.Resources.searchh;
            this.picSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSearch.Location = new System.Drawing.Point(1447, 108);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(47, 39);
            this.picSearch.TabIndex = 7;
            this.picSearch.TabStop = false;
            // 
            // UCKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.LabelNhapKM);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCKM";
            this.Size = new System.Drawing.Size(1627, 985);
            this.Load += new System.EventHandler(this.UCKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel LabelNhapKM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox picSearch;
        private Krypton.Toolkit.KryptonTextBox SearchTextbox;
    }
}
