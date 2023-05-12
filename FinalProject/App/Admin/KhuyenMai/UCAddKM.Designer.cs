namespace FinalProject.App.Admin
{
    partial class UCAddKM
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
            this.lblKM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFile = new Krypton.Toolkit.KryptonButton();
            this.txtTD = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.txtND = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCCN = new Krypton.Toolkit.KryptonComboBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbCCN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKM.Location = new System.Drawing.Point(97, 33);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(192, 24);
            this.lblKM.TabIndex = 0;
            this.lblKM.Text = "Tạo thêm khuyến mãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(138, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poster:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(138, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(138, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.CornerRoundingRadius = 30F;
            this.btnSelectFile.Location = new System.Drawing.Point(413, 77);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(122, 40);
            this.btnSelectFile.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSelectFile.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSelectFile.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSelectFile.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnSelectFile.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSelectFile.StateCommon.Border.Rounding = 30F;
            this.btnSelectFile.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSelectFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Values.Text = "Chọn tệp";
            // 
            // txtTD
            // 
            this.txtTD.Location = new System.Drawing.Point(413, 140);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(595, 43);
            this.txtTD.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTD.StateCommon.Border.Rounding = 30F;
            this.txtTD.TabIndex = 5;
            // 
            // txtND
            // 
            this.txtND.AllowDrop = true;
            this.txtND.Location = new System.Drawing.Point(413, 214);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(595, 268);
            this.txtND.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtND.StateCommon.Border.Rounding = 30F;
            this.txtND.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(138, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Áp dụng cho chi nhánh:";
            // 
            // cbCCN
            // 
            this.cbCCN.CornerRoundingRadius = 30F;
            this.cbCCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCCN.DropDownWidth = 574;
            this.cbCCN.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient;
            this.cbCCN.IntegralHeight = false;
            this.cbCCN.Location = new System.Drawing.Point(414, 520);
            this.cbCCN.Name = "cbCCN";
            this.cbCCN.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbCCN.Size = new System.Drawing.Size(594, 41);
            this.cbCCN.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCCN.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCCN.StateCommon.ComboBox.Border.Rounding = 30F;
            this.cbCCN.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCCN.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = 30F;
            this.btnAdd.Location = new System.Drawing.Point(493, 699);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 40);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 30F;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Values.Text = "Thêm";
            // 
            // UCAddKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCCN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKM);
            this.Name = "UCAddKM";
            this.Size = new System.Drawing.Size(1080, 800);
            ((System.ComponentModel.ISupportInitialize)(this.cbCCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonButton btnSelectFile;
        private Krypton.Toolkit.KryptonTextBox txtTD;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonTextBox txtND;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonComboBox cbCCN;
        private Krypton.Toolkit.KryptonButton btnAdd;
    }
}
