namespace Askhole.UserControls
{
    partial class UserButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserButton));
            this.UserName = new Bunifu.Framework.UI.BunifuFlatButton();
            this.online = new System.Windows.Forms.Label();
            this.offline = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserName.BorderRadius = 0;
            this.UserName.ButtonText = "Username";
            this.UserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserName.DisabledColor = System.Drawing.Color.Gray;
            this.UserName.Iconcolor = System.Drawing.Color.Transparent;
            this.UserName.Iconimage = ((System.Drawing.Image)(resources.GetObject("UserName.Iconimage")));
            this.UserName.Iconimage_right = null;
            this.UserName.Iconimage_right_Selected = null;
            this.UserName.Iconimage_Selected = null;
            this.UserName.IconMarginLeft = 0;
            this.UserName.IconMarginRight = 0;
            this.UserName.IconRightVisible = true;
            this.UserName.IconRightZoom = 0D;
            this.UserName.IconVisible = true;
            this.UserName.IconZoom = 90D;
            this.UserName.IsTab = false;
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Margin = new System.Windows.Forms.Padding(5);
            this.UserName.Name = "UserName";
            this.UserName.Normalcolor = System.Drawing.Color.Transparent;
            this.UserName.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.UserName.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.selected = false;
            this.UserName.Size = new System.Drawing.Size(337, 78);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserName.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.TextFont = new System.Drawing.Font("Century Gothic", 10F);
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // online
            // 
            this.online.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.online.AutoSize = true;
            this.online.BackColor = System.Drawing.Color.Transparent;
            this.online.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.online.ForeColor = System.Drawing.Color.DodgerBlue;
            this.online.Location = new System.Drawing.Point(144, 51);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(47, 17);
            this.online.TabIndex = 11;
            this.online.Text = "online";
            this.online.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.online.Visible = false;
            // 
            // offline
            // 
            this.offline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offline.AutoSize = true;
            this.offline.BackColor = System.Drawing.Color.Transparent;
            this.offline.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.offline.ForeColor = System.Drawing.Color.DimGray;
            this.offline.Location = new System.Drawing.Point(144, 51);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(47, 17);
            this.offline.TabIndex = 12;
            this.offline.Text = "offline";
            this.offline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.offline.Visible = false;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(318, 61);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 13;
            this.id.Text = "id";
            this.id.Visible = false;
            // 
            // UserButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.id);
            this.Controls.Add(this.offline);
            this.Controls.Add(this.online);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserButton";
            this.Size = new System.Drawing.Size(337, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton UserName;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.Label offline;
        private System.Windows.Forms.Label id;
    }
}
