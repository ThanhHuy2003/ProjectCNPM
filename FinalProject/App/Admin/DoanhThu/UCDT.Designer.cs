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
            this.components = new System.ComponentModel.Container();
            this.lblCNN = new System.Windows.Forms.Label();
            this.cbCNN = new Krypton.Toolkit.KryptonComboBox();
            this.lblDT1 = new System.Windows.Forms.Label();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.timeStart = new Krypton.Toolkit.KryptonDateTimePicker();
            this.timeEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtgvDT = new Krypton.Toolkit.KryptonDataGridView();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.revenueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbCNN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).BeginInit();
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
            this.cbCNN.SelectedIndexChanged += new System.EventHandler(this.cbCNN_SelectedIndexChanged);
            // 
            // lblDT1
            // 
            this.lblDT1.AutoSize = true;
            this.lblDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT1.Location = new System.Drawing.Point(46, 107);
            this.lblDT1.Name = "lblDT1";
            this.lblDT1.Size = new System.Drawing.Size(176, 24);
            this.lblDT1.TabIndex = 2;
            this.lblDT1.Text = "Chọn doanh thu từ: ";
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT2.Location = new System.Drawing.Point(541, 107);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(96, 24);
            this.lblDT2.TabIndex = 3;
            this.lblDT2.Text = "Đến ngày:";
            // 
            // timeStart
            // 
            this.timeStart.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.timeStart.CornerRoundingRadius = -1F;
            this.timeStart.Location = new System.Drawing.Point(277, 105);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(226, 29);
            this.timeStart.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.TabIndex = 6;
            // 
            // timeEnd
            // 
            this.timeEnd.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.timeEnd.CornerRoundingRadius = -1F;
            this.timeEnd.Location = new System.Drawing.Point(654, 105);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(228, 29);
            this.timeEnd.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.TabIndex = 7;
            // 
            // dtgvDT
            // 
            this.dtgvDT.ColumnHeadersHeight = 36;
            this.dtgvDT.DataSource = this.revenueBindingSource;
            this.dtgvDT.Location = new System.Drawing.Point(50, 181);
            this.dtgvDT.Name = "dtgvDT";
            this.dtgvDT.RowHeadersWidth = 51;
            this.dtgvDT.Size = new System.Drawing.Size(985, 593);
            this.dtgvDT.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvDT.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtgvDT.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvDT.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvDT.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dtgvDT.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDT.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvDT.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvDT.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvDT.TabIndex = 8;
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(FinalProject.DTO.Revenue);
            // 
            // btnSearch
            // 
            this.btnSearch.CornerRoundingRadius = 30F;
            this.btnSearch.Location = new System.Drawing.Point(904, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 49);
            this.btnSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 30F;
            this.btnSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Values.Text = "Tra cứu";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // revenueBindingSource1
            // 
            this.revenueBindingSource1.DataSource = typeof(FinalProject.DTO.Revenue);
            // 
            // UCDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgvDT);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.lblDT1);
            this.Controls.Add(this.cbCNN);
            this.Controls.Add(this.lblCNN);
            this.Name = "UCDT";
            this.Size = new System.Drawing.Size(1080, 800);
            ((System.ComponentModel.ISupportInitialize)(this.cbCNN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNN;
        private Krypton.Toolkit.KryptonComboBox cbCNN;
        private System.Windows.Forms.Label lblDT1;
        private System.Windows.Forms.Label lblDT2;
        private Krypton.Toolkit.KryptonDateTimePicker timeStart;
        private Krypton.Toolkit.KryptonDateTimePicker timeEnd;
        private Krypton.Toolkit.KryptonDataGridView dtgvDT;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private System.Windows.Forms.BindingSource revenueBindingSource1;
    }
}
