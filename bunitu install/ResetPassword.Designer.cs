namespace Askhole
{
    partial class ResetPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.Confirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Confirmation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Passconfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransition2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation3;
            this.bunifuTransition2.MaxAnimationTime = 2000;
            this.bunifuTransition2.TimeStep = 0.001F;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ForgotPassword);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 30);
            this.panel1.TabIndex = 13;
            this.panel1.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(396, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 30);
            this.panel2.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuImageButton1.Click += new System.EventHandler(this.Close_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.ForgotPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.ForgotPassword, BunifuAnimatorNS.DecorationType.None);
            this.ForgotPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotPassword.Location = new System.Drawing.Point(89, 3);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(239, 23);
            this.ForgotPassword.TabIndex = 1;
            this.ForgotPassword.Tag = "";
            this.ForgotPassword.Text = "Require  new password";
            // 
            // Confirm
            // 
            this.Confirm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirm.BorderRadius = 0;
            this.Confirm.ButtonText = "Confirm";
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Confirm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Confirm, BunifuAnimatorNS.DecorationType.None);
            this.Confirm.DisabledColor = System.Drawing.Color.Gray;
            this.Confirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Confirm.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Confirm.Iconimage = ((System.Drawing.Image)(resources.GetObject("Confirm.Iconimage")));
            this.Confirm.Iconimage_right = null;
            this.Confirm.Iconimage_right_Selected = null;
            this.Confirm.Iconimage_Selected = null;
            this.Confirm.IconMarginLeft = 0;
            this.Confirm.IconMarginRight = 0;
            this.Confirm.IconRightVisible = false;
            this.Confirm.IconRightZoom = 0D;
            this.Confirm.IconVisible = false;
            this.Confirm.IconZoom = 90D;
            this.Confirm.IsTab = false;
            this.Confirm.Location = new System.Drawing.Point(93, 371);
            this.Confirm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Confirm.Name = "Confirm";
            this.Confirm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Confirm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Confirm.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm.selected = false;
            this.Confirm.Size = new System.Drawing.Size(217, 75);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "Confirm";
            this.Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Confirm.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Email, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Email, BunifuAnimatorNS.DecorationType.None);
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.HintForeColor = System.Drawing.Color.Empty;
            this.Email.HintText = "";
            this.Email.isPassword = false;
            this.Email.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Email.LineIdleColor = System.Drawing.Color.Gray;
            this.Email.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Email.LineThickness = 3;
            this.Email.Location = new System.Drawing.Point(40, 98);
            this.Email.Margin = new System.Windows.Forms.Padding(5);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(344, 41);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Email.Enter += new System.EventHandler(this.EnterChange);
            this.Email.Leave += new System.EventHandler(this.LeaveChange);
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Username, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Username, BunifuAnimatorNS.DecorationType.None);
            this.Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Username.LineIdleColor = System.Drawing.Color.Gray;
            this.Username.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(40, 37);
            this.Username.Margin = new System.Windows.Forms.Padding(5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(344, 41);
            this.Username.TabIndex = 17;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.Enter += new System.EventHandler(this.EnterChange);
            this.Username.Leave += new System.EventHandler(this.LeaveChange);
            // 
            // Confirmation
            // 
            this.Confirmation.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.Confirmation, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Confirmation, BunifuAnimatorNS.DecorationType.None);
            this.Confirmation.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Confirmation.ForeColor = System.Drawing.Color.Red;
            this.Confirmation.Location = new System.Drawing.Point(41, 329);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(176, 19);
            this.Confirmation.TabIndex = 23;
            this.Confirmation.Text = "Passwords are not similar";
            this.Confirmation.Visible = false;
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.ErrorPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.ErrorPassword, BunifuAnimatorNS.DecorationType.None);
            this.ErrorPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorPassword.Location = new System.Drawing.Point(41, 267);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(135, 19);
            this.ErrorPassword.TabIndex = 24;
            this.ErrorPassword.Text = "Password too short";
            this.ErrorPassword.Visible = false;
            // 
            // Passconfirm
            // 
            this.Passconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Passconfirm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Passconfirm, BunifuAnimatorNS.DecorationType.None);
            this.Passconfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Passconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Passconfirm.HintForeColor = System.Drawing.Color.Empty;
            this.Passconfirm.HintText = "";
            this.Passconfirm.isPassword = false;
            this.Passconfirm.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Passconfirm.LineIdleColor = System.Drawing.Color.Gray;
            this.Passconfirm.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Passconfirm.LineThickness = 3;
            this.Passconfirm.Location = new System.Drawing.Point(40, 283);
            this.Passconfirm.Margin = new System.Windows.Forms.Padding(5);
            this.Passconfirm.Name = "Passconfirm";
            this.Passconfirm.Size = new System.Drawing.Size(344, 41);
            this.Passconfirm.TabIndex = 21;
            this.Passconfirm.Text = "Password confirmation";
            this.Passconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Passconfirm.Enter += new System.EventHandler(this.EnterConfirm);
            this.Passconfirm.Leave += new System.EventHandler(this.LeaveConfirm);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(40, 221);
            this.Password.Margin = new System.Windows.Forms.Padding(5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(344, 41);
            this.Password.TabIndex = 22;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.Enter += new System.EventHandler(this.EnterChange);
            this.Password.Leave += new System.EventHandler(this.LeaveChange);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.Error, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Error, BunifuAnimatorNS.DecorationType.None);
            this.Error.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(139, 185);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(146, 19);
            this.Error.TabIndex = 24;
            this.Error.Text = "There is no such user";
            this.Error.Visible = false;
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTransition2.SetDecoration(this.ErrorName, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.ErrorName, BunifuAnimatorNS.DecorationType.None);
            this.ErrorName.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(39, 83);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(114, 19);
            this.ErrorName.TabIndex = 25;
            this.ErrorName.Text = "Name too short";
            this.ErrorName.Visible = false;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.AutoSize = true;
            this.ErrorEmail.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTransition2.SetDecoration(this.ErrorEmail, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.ErrorEmail, BunifuAnimatorNS.DecorationType.None);
            this.ErrorEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmail.Location = new System.Drawing.Point(39, 144);
            this.ErrorEmail.Name = "ErrorEmail";
            this.ErrorEmail.Size = new System.Drawing.Size(207, 19);
            this.ErrorEmail.TabIndex = 26;
            this.ErrorEmail.Text = "You need to fill in your e-mail";
            this.ErrorEmail.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            this.bunifuTransition1.MaxAnimationTime = 2000;
            this.bunifuTransition1.TimeStep = 0.001F;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "sm.jpg");
            this.ImageList.Images.SetKeyName(1, "sm1.jpg");
            this.ImageList.Images.SetKeyName(2, "sm2.jpg");
            this.ImageList.Images.SetKeyName(3, "sm3.jpg");
            this.ImageList.Images.SetKeyName(4, "sm4.jpg");
            this.ImageList.Images.SetKeyName(5, "sm5.jpg");
            this.ImageList.Images.SetKeyName(6, "sm6.jpg");
            this.ImageList.Images.SetKeyName(7, "sm7.jpg");
            this.ImageList.Images.SetKeyName(8, "sm8.jpg");
            this.ImageList.Images.SetKeyName(9, "sm9.jpg");
            this.ImageList.Images.SetKeyName(10, "sm10.jpg");
            this.ImageList.Images.SetKeyName(11, "sm11.jpg");
            this.ImageList.Images.SetKeyName(12, "sm12.jpg");
            this.ImageList.Images.SetKeyName(13, "sm13.jpg");
            this.ImageList.Images.SetKeyName(14, "sm23.jpg");
            this.ImageList.Images.SetKeyName(15, "smalltalk.jpg");
            this.ImageList.Images.SetKeyName(16, "smtalk.jpg");
            this.ImageList.Images.SetKeyName(17, "smtalk1.jpg");
            this.ImageList.Images.SetKeyName(18, "smtalk2.jpg");
            this.ImageList.Images.SetKeyName(19, "smtalk3.jpg");
            this.ImageList.Images.SetKeyName(20, "smtalk4.jpg");
            this.ImageList.Images.SetKeyName(21, "smtalk6.jpg");
            this.ImageList.Images.SetKeyName(22, "smtalk7.jpg");
            this.ImageList.Images.SetKeyName(23, "smtalk8.jpg");
            this.ImageList.Images.SetKeyName(24, "smtalk9.jpg");
            this.ImageList.Images.SetKeyName(25, "smtalk10.jpg");
            this.ImageList.Images.SetKeyName(26, "smtalk11.jpg");
            this.ImageList.Images.SetKeyName(27, "smtalk12.jpg");
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.ForgotPassword;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 469);
            this.Controls.Add(this.ErrorEmail);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.Confirmation);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.ErrorPassword);
            this.Controls.Add(this.Passconfirm);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Username);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.ImageList ImageList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label ForgotPassword;
        private Bunifu.Framework.UI.BunifuFlatButton Confirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomLabel Confirmation;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Passconfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuCustomLabel Error;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorName;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorEmail;
    }
}