namespace FinalProject.App.Staff.CaiDat
{
    partial class UCCDStaff
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
            this.tabTTCN = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabLS = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.CBQQ = new Krypton.Toolkit.KryptonComboBox();
            this.lblQQ = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnSDT = new Krypton.Toolkit.KryptonButton();
            this.txtSDT = new Krypton.Toolkit.KryptonTextBox();
            this.btnEmail = new Krypton.Toolkit.KryptonButton();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.btnNS = new Krypton.Toolkit.KryptonButton();
            this.txtNS = new Krypton.Toolkit.KryptonTextBox();
            this.btnHoTen = new Krypton.Toolkit.KryptonButton();
            this.txtHoten = new Krypton.Toolkit.KryptonTextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.labelHoten = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSignOut = new Krypton.Toolkit.KryptonButton();
            this.tabTTCN.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabLS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBQQ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTTCN
            // 
            this.tabTTCN.Controls.Add(this.tabPage1);
            this.tabTTCN.Controls.Add(this.TabLS);
            this.tabTTCN.Location = new System.Drawing.Point(0, 6);
            this.tabTTCN.Name = "tabTTCN";
            this.tabTTCN.SelectedIndex = 0;
            this.tabTTCN.Size = new System.Drawing.Size(1217, 793);
            this.tabTTCN.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.tabPage1.Controls.Add(this.btnSignOut);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CBQQ);
            this.tabPage1.Controls.Add(this.lblQQ);
            this.tabPage1.Controls.Add(this.lblNS);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnSDT);
            this.tabPage1.Controls.Add(this.txtSDT);
            this.tabPage1.Controls.Add(this.btnEmail);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.btnNS);
            this.tabPage1.Controls.Add(this.txtNS);
            this.tabPage1.Controls.Add(this.btnHoTen);
            this.tabPage1.Controls.Add(this.txtHoten);
            this.tabPage1.Controls.Add(this.lblSDT);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.labelHoten);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1209, 767);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cá nhân";
            // 
            // TabLS
            // 
            this.TabLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.TabLS.Controls.Add(this.flowLayoutPanel1);
            this.TabLS.Controls.Add(this.label13);
            this.TabLS.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.TabLS.Location = new System.Drawing.Point(4, 22);
            this.TabLS.Name = "TabLS";
            this.TabLS.Padding = new System.Windows.Forms.Padding(3);
            this.TabLS.Size = new System.Drawing.Size(1209, 767);
            this.TabLS.TabIndex = 1;
            this.TabLS.Text = "Lịch sử đơn hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(438, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 37);
            this.label3.TabIndex = 91;
            this.label3.Text = "Chỉnh sửa thông tin cá nhân ";
            // 
            // CBQQ
            // 
            this.CBQQ.CornerRoundingRadius = 30F;
            this.CBQQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBQQ.DropDownWidth = 610;
            this.CBQQ.IntegralHeight = false;
            this.CBQQ.Location = new System.Drawing.Point(293, 504);
            this.CBQQ.Name = "CBQQ";
            this.CBQQ.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.CBQQ.Size = new System.Drawing.Size(630, 41);
            this.CBQQ.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CBQQ.StateCommon.ComboBox.Border.Rounding = 30F;
            this.CBQQ.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CBQQ.TabIndex = 90;
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lblQQ.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblQQ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblQQ.Location = new System.Drawing.Point(297, 476);
            this.lblQQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(104, 25);
            this.lblQQ.TabIndex = 87;
            this.lblQQ.Text = "Quê quán: ";
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lblNS.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblNS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNS.Location = new System.Drawing.Point(297, 238);
            this.lblNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(105, 25);
            this.lblNS.TabIndex = 86;
            this.lblNS.Text = "Ngày sinh: ";
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnSave.CornerRoundingRadius = 20F;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(506, 620);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 37);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 20F;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSave.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSave.TabIndex = 85;
            this.btnSave.Values.Text = "Lưu";
            // 
            // btnSDT
            // 
            this.btnSDT.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnSDT.CornerRoundingRadius = 0F;
            this.btnSDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSDT.Location = new System.Drawing.Point(873, 420);
            this.btnSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSDT.Name = "btnSDT";
            this.btnSDT.Size = new System.Drawing.Size(40, 33);
            this.btnSDT.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSDT.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSDT.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSDT.StateCommon.Border.Rounding = 0F;
            this.btnSDT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSDT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSDT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDT.TabIndex = 84;
            this.btnSDT.Values.Image = global::FinalProject.Properties.Resources.Edit;
            this.btnSDT.Values.Text = "";
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(293, 418);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(630, 40);
            this.txtSDT.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSDT.StateCommon.Border.Rounding = 20F;
            this.txtSDT.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.TabIndex = 83;
            // 
            // btnEmail
            // 
            this.btnEmail.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnEmail.CornerRoundingRadius = 0F;
            this.btnEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEmail.Location = new System.Drawing.Point(873, 340);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(40, 33);
            this.btnEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnEmail.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEmail.StateCommon.Border.Rounding = 0F;
            this.btnEmail.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEmail.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEmail.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.TabIndex = 82;
            this.btnEmail.Values.Image = global::FinalProject.Properties.Resources.Edit;
            this.btnEmail.Values.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(293, 338);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(630, 40);
            this.txtEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 20F;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.TabIndex = 81;
            // 
            // btnNS
            // 
            this.btnNS.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnNS.CornerRoundingRadius = 0F;
            this.btnNS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNS.Location = new System.Drawing.Point(873, 266);
            this.btnNS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNS.Name = "btnNS";
            this.btnNS.Size = new System.Drawing.Size(40, 33);
            this.btnNS.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnNS.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnNS.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNS.StateCommon.Border.Rounding = 0F;
            this.btnNS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNS.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNS.TabIndex = 80;
            this.btnNS.Values.Image = global::FinalProject.Properties.Resources.Edit;
            this.btnNS.Values.Text = "";
            // 
            // txtNS
            // 
            this.txtNS.Enabled = false;
            this.txtNS.Location = new System.Drawing.Point(293, 264);
            this.txtNS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(630, 40);
            this.txtNS.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNS.StateCommon.Border.Rounding = 20F;
            this.txtNS.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNS.TabIndex = 79;
            // 
            // btnHoTen
            // 
            this.btnHoTen.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnHoTen.CornerRoundingRadius = 0F;
            this.btnHoTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHoTen.Location = new System.Drawing.Point(873, 186);
            this.btnHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(40, 33);
            this.btnHoTen.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnHoTen.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnHoTen.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHoTen.StateCommon.Border.Rounding = 0F;
            this.btnHoTen.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHoTen.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHoTen.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoTen.TabIndex = 78;
            this.btnHoTen.Values.Image = global::FinalProject.Properties.Resources.Edit;
            this.btnHoTen.Values.Text = "";
            // 
            // txtHoten
            // 
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(293, 184);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(630, 40);
            this.txtHoten.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHoten.StateCommon.Border.Rounding = 20F;
            this.txtHoten.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.TabIndex = 77;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblSDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSDT.Location = new System.Drawing.Point(297, 392);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(132, 25);
            this.lblSDT.TabIndex = 76;
            this.lblSDT.Text = "Số điện thoại: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(297, 312);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Email: ";
            // 
            // labelHoten
            // 
            this.labelHoten.AutoSize = true;
            this.labelHoten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.labelHoten.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelHoten.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHoten.Location = new System.Drawing.Point(297, 154);
            this.labelHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoten.Name = "labelHoten";
            this.labelHoten.Size = new System.Drawing.Size(77, 25);
            this.labelHoten.TabIndex = 74;
            this.labelHoten.Text = "Họ tên: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 20.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(490, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 38);
            this.label13.TabIndex = 72;
            this.label13.Text = "LỊCH SỬ ĐƠN HÀNG";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1170, 653);
            this.flowLayoutPanel1.TabIndex = 73;
            // 
            // btnSignOut
            // 
            this.btnSignOut.CornerRoundingRadius = 30F;
            this.btnSignOut.Location = new System.Drawing.Point(1003, 19);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.Size = new System.Drawing.Size(199, 37);
            this.btnSignOut.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.StateCommon.Border.Rounding = 30F;
            this.btnSignOut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignOut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignOut.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.TabIndex = 92;
            this.btnSignOut.Values.Text = "Đăng xuất";
            // 
            // UCCDStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabTTCN);
            this.Name = "UCCDStaff";
            this.Size = new System.Drawing.Size(1220, 800);
            this.tabTTCN.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabLS.ResumeLayout(false);
            this.TabLS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBQQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTTCN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabLS;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonComboBox CBQQ;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.Label lblNS;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnSDT;
        private Krypton.Toolkit.KryptonTextBox txtSDT;
        private Krypton.Toolkit.KryptonButton btnEmail;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonButton btnNS;
        private Krypton.Toolkit.KryptonTextBox txtNS;
        private Krypton.Toolkit.KryptonButton btnHoTen;
        private Krypton.Toolkit.KryptonTextBox txtHoten;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label13;
        private Krypton.Toolkit.KryptonButton btnSignOut;
    }
}
