namespace bunitu_install
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.autho = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.birthDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Passconfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Signup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ErrorName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Confirmation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.autho;
            this.bunifuDragControl1.Vertical = true;
            // 
            // autho
            // 
            this.autho.AutoSize = true;
            this.autho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autho.Location = new System.Drawing.Point(143, 2);
            this.autho.Name = "autho";
            this.autho.Size = new System.Drawing.Size(136, 23);
            this.autho.TabIndex = 1;
            this.autho.Tag = "";
            this.autho.Text = "Authorization";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.autho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(399, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 30);
            this.panel2.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 316);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 21);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Date of birth";
            // 
            // birthDay
            // 
            this.birthDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.birthDay.BorderRadius = 0;
            this.birthDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.birthDay.FormatCustom = null;
            this.birthDay.Location = new System.Drawing.Point(12, 338);
            this.birthDay.Margin = new System.Windows.Forms.Padding(5);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(404, 44);
            this.birthDay.TabIndex = 9;
            this.birthDay.Value = new System.DateTime(2018, 2, 16, 18, 53, 57, 792);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.HintForeColor = System.Drawing.Color.Empty;
            this.Email.HintText = "";
            this.Email.isPassword = false;
            this.Email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Email.LineIdleColor = System.Drawing.Color.Gray;
            this.Email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Email.LineThickness = 3;
            this.Email.Location = new System.Drawing.Point(13, 239);
            this.Email.Margin = new System.Windows.Forms.Padding(5);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(404, 41);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Email.Enter += new System.EventHandler(this.EnterChange);
            this.Email.Leave += new System.EventHandler(this.LeaveChange);
            // 
            // Passconfirm
            // 
            this.Passconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passconfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Passconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Passconfirm.HintForeColor = System.Drawing.Color.Empty;
            this.Passconfirm.HintText = "";
            this.Passconfirm.isPassword = false;
            this.Passconfirm.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Passconfirm.LineIdleColor = System.Drawing.Color.Gray;
            this.Passconfirm.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Passconfirm.LineThickness = 3;
            this.Passconfirm.Location = new System.Drawing.Point(12, 171);
            this.Passconfirm.Margin = new System.Windows.Forms.Padding(5);
            this.Passconfirm.Name = "Passconfirm";
            this.Passconfirm.Size = new System.Drawing.Size(404, 41);
            this.Passconfirm.TabIndex = 6;
            this.Passconfirm.Text = "Password confirmation";
            this.Passconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Passconfirm.Enter += new System.EventHandler(this.Passconfirm_Enter);
            this.Passconfirm.Leave += new System.EventHandler(this.Passconfirm_Leave);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(12, 103);
            this.Password.Margin = new System.Windows.Forms.Padding(5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(404, 41);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.Enter += new System.EventHandler(this.EnterChange);
            this.Password.Leave += new System.EventHandler(this.LeaveChange);
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Username.LineIdleColor = System.Drawing.Color.Gray;
            this.Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(13, 38);
            this.Username.Margin = new System.Windows.Forms.Padding(5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(404, 41);
            this.Username.TabIndex = 8;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.Enter += new System.EventHandler(this.EnterChange);
            this.Username.Leave += new System.EventHandler(this.LeaveChange);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "I already have account";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(75, 524);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(281, 50);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BackToSignIn_Click);
            // 
            // Signup
            // 
            this.Signup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signup.BorderRadius = 0;
            this.Signup.ButtonText = "Sign-up";
            this.Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup.DisabledColor = System.Drawing.Color.Gray;
            this.Signup.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Signup.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Signup.Iconimage = ((System.Drawing.Image)(resources.GetObject("Signup.Iconimage")));
            this.Signup.Iconimage_right = null;
            this.Signup.Iconimage_right_Selected = null;
            this.Signup.Iconimage_Selected = null;
            this.Signup.IconMarginLeft = 0;
            this.Signup.IconMarginRight = 0;
            this.Signup.IconRightVisible = false;
            this.Signup.IconRightZoom = 0D;
            this.Signup.IconVisible = false;
            this.Signup.IconZoom = 90D;
            this.Signup.IsTab = false;
            this.Signup.Location = new System.Drawing.Point(124, 430);
            this.Signup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Signup.Name = "Signup";
            this.Signup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Signup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Signup.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Signup.selected = false;
            this.Signup.Size = new System.Drawing.Size(173, 75);
            this.Signup.TabIndex = 11;
            this.Signup.Text = "Sign-up";
            this.Signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signup.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Signup.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.BackColor = System.Drawing.SystemColors.Window;
            this.ErrorName.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(12, 84);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(114, 19);
            this.ErrorName.TabIndex = 15;
            this.ErrorName.Text = "Name too short";
            this.ErrorName.Visible = false;
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.ErrorPassword.BackColor = System.Drawing.SystemColors.Window;
            this.ErrorPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorPassword.Location = new System.Drawing.Point(13, 149);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(135, 19);
            this.ErrorPassword.TabIndex = 16;
            this.ErrorPassword.Text = "Password too short";
            this.ErrorPassword.Visible = false;
            // 
            // Confirmation
            // 
            this.Confirmation.AutoSize = true;
            this.Confirmation.BackColor = System.Drawing.SystemColors.Window;
            this.Confirmation.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Confirmation.ForeColor = System.Drawing.Color.Red;
            this.Confirmation.Location = new System.Drawing.Point(13, 217);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(176, 19);
            this.Confirmation.TabIndex = 16;
            this.Confirmation.Text = "Passwords are not similar";
            this.Confirmation.Visible = false;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.SystemColors.Window;
            this.Error.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(111, 398);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(198, 19);
            this.Error.TabIndex = 17;
            this.Error.Text = "Error there is such username";
            this.Error.Visible = false;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.AutoSize = true;
            this.ErrorEmail.BackColor = System.Drawing.SystemColors.Window;
            this.ErrorEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmail.Location = new System.Drawing.Point(13, 285);
            this.ErrorEmail.Name = "ErrorEmail";
            this.ErrorEmail.Size = new System.Drawing.Size(207, 19);
            this.ErrorEmail.TabIndex = 16;
            this.ErrorEmail.Text = "You need to fill in your e-mail";
            this.ErrorEmail.Visible = false;
            // 
            // Authorization
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(428, 589);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.ErrorEmail);
            this.Controls.Add(this.Confirmation);
            this.Controls.Add(this.ErrorPassword);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.birthDay);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Passconfirm);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton Signup;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker birthDay;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Passconfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label autho;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorName;
        private Bunifu.Framework.UI.BunifuCustomLabel Confirmation;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel Error;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorEmail;
    }
}

