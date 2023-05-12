namespace FinalProject.App.Admin
{
    partial class UCDT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCNN = new System.Windows.Forms.Label();
            this.cbCNN = new Krypton.Toolkit.KryptonComboBox();
            this.lblDT1 = new System.Windows.Forms.Label();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.DGVDT = new Krypton.Toolkit.KryptonDataGridView();
            this.Ngày = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cbCNN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCNN
            // 
            this.lblCNN.AutoSize = true;
            this.lblCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCNN.Location = new System.Drawing.Point(50, 23);
            this.lblCNN.Name = "lblCNN";
            this.lblCNN.Size = new System.Drawing.Size(150, 24);
            this.lblCNN.TabIndex = 0;
            this.lblCNN.Text = "Chọn chi nhánh:";
            // 
            // cbCNN
            // 
            this.cbCNN.CornerRoundingRadius = 30F;
            this.cbCNN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCNN.DropDownWidth = 262;
            this.cbCNN.IntegralHeight = false;
            this.cbCNN.Location = new System.Drawing.Point(277, 15);
            this.cbCNN.Name = "cbCNN";
            this.cbCNN.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.cbCNN.Size = new System.Drawing.Size(282, 41);
            this.cbCNN.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCNN.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCNN.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCNN.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCNN.StateCommon.ComboBox.Border.Rounding = 30F;
            this.cbCNN.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCNN.TabIndex = 1;
            // 
            // lblDT1
            // 
            this.lblDT1.AutoSize = true;
            this.lblDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT1.Location = new System.Drawing.Point(46, 104);
            this.lblDT1.Name = "lblDT1";
            this.lblDT1.Size = new System.Drawing.Size(176, 24);
            this.lblDT1.TabIndex = 2;
            this.lblDT1.Text = "Chọn doanh thu từ: ";
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT2.Location = new System.Drawing.Point(46, 171);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(96, 24);
            this.lblDT2.TabIndex = 3;
            this.lblDT2.Text = "Đến ngày:";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.kryptonDateTimePicker1.CornerRoundingRadius = -1F;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(277, 102);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.ShowUpDown = true;
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.kryptonDateTimePicker1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDateTimePicker1.TabIndex = 6;
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.kryptonDateTimePicker2.CornerRoundingRadius = -1F;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(277, 169);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.ShowUpDown = true;
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.kryptonDateTimePicker2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDateTimePicker2.TabIndex = 7;
            // 
            // DGVDT
            // 
            this.DGVDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngày,
            this.Column1});
            this.DGVDT.Location = new System.Drawing.Point(34, 246);
            this.DGVDT.Name = "DGVDT";
            this.DGVDT.Size = new System.Drawing.Size(1012, 528);
            this.DGVDT.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.DGVDT.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DGVDT.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DGVDT.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DGVDT.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DGVDT.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDT.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DGVDT.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DGVDT.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.DGVDT.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DGVDT.TabIndex = 8;
            // 
            // Ngày
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Ngày.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ngày.HeaderText = "Thời gian ";
            this.Ngày.Name = "Ngày";
            this.Ngày.Width = 475;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Tổng tiền ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 475;
            // 
            // UCDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DGVDT);
            this.Controls.Add(this.kryptonDateTimePicker2);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.lblDT1);
            this.Controls.Add(this.cbCNN);
            this.Controls.Add(this.lblCNN);
            this.Name = "UCDT";
            this.Size = new System.Drawing.Size(1080, 800);
            ((System.ComponentModel.ISupportInitialize)(this.cbCNN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNN;
        private Krypton.Toolkit.KryptonComboBox cbCNN;
        private System.Windows.Forms.Label lblDT1;
        private System.Windows.Forms.Label lblDT2;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private Krypton.Toolkit.KryptonDataGridView DGVDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngày;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
