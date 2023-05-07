namespace FinalProject.App.Login
{
    partial class UCDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDK));
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Eye2 = new System.Windows.Forms.Button();
            this.Blind2 = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.panel_DN = new System.Windows.Forms.Panel();
            this.FullNameText = new Krypton.Toolkit.KryptonTextBox();
            this.EmailText = new Krypton.Toolkit.KryptonTextBox();
            this.ContactText = new Krypton.Toolkit.KryptonTextBox();
            this.UserNameText = new Krypton.Toolkit.KryptonTextBox();
            this.PasswordText = new Krypton.Toolkit.KryptonTextBox();
            this.PhoneNumberText = new Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.CornerRoundingRadius = 30F;
            this.kryptonButton2.Location = new System.Drawing.Point(197, 764);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(272, 80);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 30F;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 36;
            this.kryptonButton2.Values.Text = "Sign up";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft New Tai Lue", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(229, 226);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(195, 66);
            this.lblSignUp.TabIndex = 26;
            this.lblSignUp.Text = "Sign up";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(256, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Eye2
            // 
            this.Eye2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eye2.BackgroundImage")));
            this.Eye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eye2.Location = new System.Drawing.Point(505, 698);
            this.Eye2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eye2.Name = "Eye2";
            this.Eye2.Size = new System.Drawing.Size(35, 30);
            this.Eye2.TabIndex = 29;
            this.Eye2.UseVisualStyleBackColor = true;
            this.Eye2.Click += new System.EventHandler(this.Eye2_Click);
            // 
            // Blind2
            // 
            this.Blind2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Blind2.BackgroundImage")));
            this.Blind2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blind2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Blind2.Location = new System.Drawing.Point(505, 698);
            this.Blind2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Blind2.Name = "Blind2";
            this.Blind2.Size = new System.Drawing.Size(35, 30);
            this.Blind2.TabIndex = 30;
            this.Blind2.UseVisualStyleBackColor = true;
            this.Blind2.Click += new System.EventHandler(this.Blind2_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDN.FlatAppearance.BorderSize = 0;
            this.btnDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDN.Image = global::FinalProject.Properties.Resources.arrow;
            this.btnDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDN.Location = new System.Drawing.Point(16, 15);
            this.btnDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(171, 47);
            this.btnDN.TabIndex = 37;
            this.btnDN.Text = "    Sign in";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // panel_DN
            // 
            this.panel_DN.Location = new System.Drawing.Point(505, 27);
            this.panel_DN.Margin = new System.Windows.Forms.Padding(4);
            this.panel_DN.Name = "panel_DN";
            this.panel_DN.Size = new System.Drawing.Size(157, 65);
            this.panel_DN.TabIndex = 41;
            this.panel_DN.Visible = false;
            // 
            // FullNameText
            // 
            this.FullNameText.Location = new System.Drawing.Point(117, 343);
            this.FullNameText.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(432, 39);
            this.FullNameText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.FullNameText.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.FullNameText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FullNameText.StateCommon.Border.Rounding = 20F;
            this.FullNameText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.FullNameText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameText.TabIndex = 42;
            this.FullNameText.Text = "Full name";
            this.FullNameText.Enter += new System.EventHandler(this.FullNameText_Enter);
            this.FullNameText.Leave += new System.EventHandler(this.FullNameText_Leave);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(117, 415);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(432, 39);
            this.EmailText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.EmailText.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.EmailText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EmailText.StateCommon.Border.Rounding = 20F;
            this.EmailText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.EmailText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.TabIndex = 43;
            this.EmailText.Text = "Email";
            this.EmailText.Enter += new System.EventHandler(this.EmailText_Enter);
            this.EmailText.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(117, 486);
            this.ContactText.Margin = new System.Windows.Forms.Padding(4);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(432, 39);
            this.ContactText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.ContactText.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.ContactText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ContactText.StateCommon.Border.Rounding = 20F;
            this.ContactText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.ContactText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactText.TabIndex = 44;
            this.ContactText.Text = "Contact address";
            this.ContactText.Enter += new System.EventHandler(this.ContactText_Enter);
            this.ContactText.Leave += new System.EventHandler(this.ContactText_Leave);
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(117, 623);
            this.UserNameText.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(432, 39);
            this.UserNameText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.UserNameText.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.UserNameText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserNameText.StateCommon.Border.Rounding = 20F;
            this.UserNameText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.UserNameText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameText.TabIndex = 46;
            this.UserNameText.Text = "Username";
            this.UserNameText.Enter += new System.EventHandler(this.UserNameText_Enter);
            this.UserNameText.Leave += new System.EventHandler(this.UserNameText_Leave);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(117, 690);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(432, 39);
            this.PasswordText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.PasswordText.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.PasswordText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordText.StateCommon.Border.Rounding = 20F;
            this.PasswordText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.PasswordText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.TabIndex = 47;
            this.PasswordText.Text = "Password";
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.PasswordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(117, 558);
            this.PhoneNumberText.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(432, 39);
            this.PhoneNumberText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.PhoneNumberText.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.PhoneNumberText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PhoneNumberText.StateCommon.Border.Rounding = 20F;
            this.PhoneNumberText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.PhoneNumberText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberText.TabIndex = 48;
            this.PhoneNumberText.Text = "Phone number";
            this.PhoneNumberText.Enter += new System.EventHandler(this.PhoneNumberText_Enter);
            this.PhoneNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberText_KeyPress);
            this.PhoneNumberText.Leave += new System.EventHandler(this.PhoneNumberText_Leave);
            // 
            // UCDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.panel_DN);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.ContactText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.FullNameText);
            this.Controls.Add(this.Eye2);
            this.Controls.Add(this.Blind2);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PhoneNumberText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDK";
            this.Size = new System.Drawing.Size(700, 874);
            this.Load += new System.EventHandler(this.UCDK_Load);
            this.Click += new System.EventHandler(this.UCDK_Clicked);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Eye2;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button Blind2;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Panel panel_DN;
        private Krypton.Toolkit.KryptonTextBox FullNameText;
        private Krypton.Toolkit.KryptonTextBox EmailText;
        private Krypton.Toolkit.KryptonTextBox ContactText;
        private Krypton.Toolkit.KryptonTextBox UserNameText;
        private Krypton.Toolkit.KryptonTextBox PasswordText;
        private Krypton.Toolkit.KryptonMaskedTextBox PhoneNumberText;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
    }
}
