namespace bunitu_install
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Resize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UserHeader = new System.Windows.Forms.Panel();
            this.MenuSearch = new System.Windows.Forms.Panel();
            this.Hamburger = new Bunifu.Framework.UI.BunifuImageButton();
            this.Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserList = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Chat = new System.Windows.Forms.Panel();
            this.chat1 = new bunitu_install.Chat();
            this.Header.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.UserHeader.SuspendLayout();
            this.MenuSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hamburger)).BeginInit();
            this.UserList.SuspendLayout();
            this.Chat.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Header.Controls.Add(this.panel2);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(753, 24);
            this.Header.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Resize);
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(685, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 24);
            this.panel2.TabIndex = 1;
            // 
            // Resize
            // 
            this.Resize.BackColor = System.Drawing.Color.Transparent;
            this.Resize.Image = ((System.Drawing.Image)(resources.GetObject("Resize.Image")));
            this.Resize.ImageActive = null;
            this.Resize.Location = new System.Drawing.Point(23, 4);
            this.Resize.Margin = new System.Windows.Forms.Padding(2);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(22, 16);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 1;
            this.Resize.TabStop = false;
            this.Resize.Zoom = 20;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageActive = null;
            this.Minimize.Location = new System.Drawing.Point(1, -2);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(22, 24);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Zoom = 20;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageActive = null;
            this.Close.Location = new System.Drawing.Point(46, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(22, 24);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Zoom = 20;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // UserHeader
            // 
            this.UserHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserHeader.Controls.Add(this.MenuSearch);
            this.UserHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserHeader.Location = new System.Drawing.Point(0, 24);
            this.UserHeader.Name = "UserHeader";
            this.UserHeader.Size = new System.Drawing.Size(753, 46);
            this.UserHeader.TabIndex = 1;
            // 
            // MenuSearch
            // 
            this.MenuSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuSearch.Controls.Add(this.Hamburger);
            this.MenuSearch.Controls.Add(this.Search);
            this.MenuSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuSearch.Location = new System.Drawing.Point(0, 0);
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(252, 46);
            this.MenuSearch.TabIndex = 0;
            // 
            // Hamburger
            // 
            this.Hamburger.BackColor = System.Drawing.Color.Transparent;
            this.Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("Hamburger.Image")));
            this.Hamburger.ImageActive = ((System.Drawing.Image)(resources.GetObject("Hamburger.ImageActive")));
            this.Hamburger.Location = new System.Drawing.Point(8, 5);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(40, 40);
            this.Hamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hamburger.TabIndex = 1;
            this.Hamburger.TabStop = false;
            this.Hamburger.Zoom = 10;
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.HintForeColor = System.Drawing.Color.Empty;
            this.Search.HintText = "";
            this.Search.isPassword = false;
            this.Search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Search.LineIdleColor = System.Drawing.Color.Gray;
            this.Search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Search.LineThickness = 4;
            this.Search.Location = new System.Drawing.Point(56, 4);
            this.Search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(191, 37);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserList
            // 
            this.UserList.AutoScroll = true;
            this.UserList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserList.Controls.Add(this.bunifuFlatButton2);
            this.UserList.Controls.Add(this.bunifuFlatButton1);
            this.UserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserList.Location = new System.Drawing.Point(0, 70);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(253, 500);
            this.UserList.TabIndex = 2;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "User";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 72);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(253, 66);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Text = "User";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "User";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(253, 66);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "User";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Chat
            // 
            this.Chat.Controls.Add(this.chat1);
            this.Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chat.Location = new System.Drawing.Point(253, 70);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(500, 500);
            this.Chat.TabIndex = 3;
            // 
            // chat1
            // 
            this.chat1.AutoScroll = true;
            this.chat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat1.Location = new System.Drawing.Point(0, 0);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(500, 500);
            this.chat1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(753, 570);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.UserHeader);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.UserHeader.ResumeLayout(false);
            this.MenuSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hamburger)).EndInit();
            this.UserList.ResumeLayout(false);
            this.Chat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Resize;
        private Bunifu.Framework.UI.BunifuImageButton Minimize;
        private Bunifu.Framework.UI.BunifuImageButton Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel UserList;
        private System.Windows.Forms.Panel UserHeader;
        private System.Windows.Forms.Panel MenuSearch;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuImageButton Hamburger;
        private System.Windows.Forms.Panel Chat;
        private Chat chat1;
    }
}