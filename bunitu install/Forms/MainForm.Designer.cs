using System.Data.SqlClient;

namespace Askhole
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.online = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuSearch = new System.Windows.Forms.Panel();
            this.Hamburger = new Bunifu.Framework.UI.BunifuImageButton();
            this.Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserList = new System.Windows.Forms.Panel();
            this.settings1 = new Askhole.UserControls.Settings();
            this.contactList1 = new Askhole.ContactList();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Chat = new System.Windows.Forms.Panel();
            this.chat1 = new Askhole.Chat();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Header.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.UserHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1004, 30);
            this.Header.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Resize);
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(913, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 30);
            this.panel2.TabIndex = 1;
            // 
            // Resize
            // 
            this.Resize.BackColor = System.Drawing.Color.Transparent;
            this.Resize.Image = global::Askhole.Properties.Resources.sq;
            this.Resize.ImageActive = null;
            this.Resize.Location = new System.Drawing.Point(31, 5);
            this.Resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(29, 20);
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
            this.Minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 30);
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
            this.Close.Location = new System.Drawing.Point(61, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 30);
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
            this.UserHeader.Controls.Add(this.tableLayoutPanel1);
            this.UserHeader.Controls.Add(this.panel1);
            this.UserHeader.Controls.Add(this.MenuSearch);
            this.UserHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserHeader.Location = new System.Drawing.Point(0, 30);
            this.UserHeader.Margin = new System.Windows.Forms.Padding(4);
            this.UserHeader.Name = "UserHeader";
            this.UserHeader.Size = new System.Drawing.Size(1004, 57);
            this.UserHeader.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.online, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Name, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(394, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Hamburger_Click);
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.online.ForeColor = System.Drawing.Color.DodgerBlue;
            this.online.Location = new System.Drawing.Point(3, 0);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(0, 17);
            this.online.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(206, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "online";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Name
            // 
            this.Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Name.Location = new System.Drawing.Point(206, 7);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(197, 21);
            this.Name.TabIndex = 11;
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(337, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 57);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuSearch
            // 
            this.MenuSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuSearch.Controls.Add(this.Hamburger);
            this.MenuSearch.Controls.Add(this.Search);
            this.MenuSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuSearch.Location = new System.Drawing.Point(0, 0);
            this.MenuSearch.Margin = new System.Windows.Forms.Padding(4);
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(337, 57);
            this.MenuSearch.TabIndex = 0;
            // 
            // Hamburger
            // 
            this.Hamburger.BackColor = System.Drawing.Color.Transparent;
            this.Hamburger.Image = ((System.Drawing.Image)(resources.GetObject("Hamburger.Image")));
            this.Hamburger.ImageActive = ((System.Drawing.Image)(resources.GetObject("Hamburger.ImageActive")));
            this.Hamburger.Location = new System.Drawing.Point(11, 6);
            this.Hamburger.Margin = new System.Windows.Forms.Padding(4);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(53, 49);
            this.Hamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hamburger.TabIndex = 1;
            this.Hamburger.TabStop = false;
            this.Hamburger.Zoom = 10;
            this.Hamburger.Click += new System.EventHandler(this.Hamburger_Click);
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
            this.Search.Location = new System.Drawing.Point(75, 5);
            this.Search.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(255, 46);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // UserList
            // 
            this.UserList.AutoScroll = true;
            this.UserList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserList.Controls.Add(this.settings1);
            this.UserList.Controls.Add(this.contactList1);
            this.UserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserList.Location = new System.Drawing.Point(0, 87);
            this.UserList.Margin = new System.Windows.Forms.Padding(4);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(337, 615);
            this.UserList.TabIndex = 2;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.White;
            this.settings1.Location = new System.Drawing.Point(0, 0);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(337, 337);
            this.settings1.TabIndex = 1;
            this.settings1.Visible = false;
            this.settings1.Load += new System.EventHandler(this.settings1_Load);
            this.settings1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Hamburger_Click);
            // 
            // contactList1
            // 
            this.contactList1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contactList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.contactList1.Location = new System.Drawing.Point(0, 0);
            this.contactList1.Margin = new System.Windows.Forms.Padding(5);
            this.contactList1.Name = "contactList1";
            this.contactList1.Size = new System.Drawing.Size(337, 615);
            this.contactList1.TabIndex = 0;
            this.contactList1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Hamburger_Click);
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
            this.Chat.Location = new System.Drawing.Point(337, 87);
            this.Chat.Margin = new System.Windows.Forms.Padding(4);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(667, 615);
            this.Chat.TabIndex = 3;
            // 
            // chat1
            // 
            this.chat1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat1.AutoScroll = true;
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.chat1.Location = new System.Drawing.Point(0, 0);
            this.chat1.Margin = new System.Windows.Forms.Padding(5);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(667, 615);
            this.chat1.TabIndex = 0;
            this.chat1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Hamburger_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1004, 702);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.UserHeader);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.UserHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton Hamburger;
        private System.Windows.Forms.Panel Chat;
        private Chat chat1;
        private ContactList contactList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private UserControls.Settings settings1;
    }
}