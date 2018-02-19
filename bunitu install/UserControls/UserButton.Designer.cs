namespace bunitu_install.UserControls
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
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.UserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserName.Name = "UserName";
            this.UserName.Normalcolor = System.Drawing.Color.Transparent;
            this.UserName.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserName.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.selected = false;
            this.UserName.Size = new System.Drawing.Size(337, 78);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserName.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.TextFont = new System.Drawing.Font("Century Gothic", 10F);
             // 
            // UserButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserButton";
            this.Size = new System.Drawing.Size(337, 81);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton UserName;
    }
}
