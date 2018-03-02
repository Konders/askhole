namespace Askhole
{
    partial class ContactList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactList));
            this.List_Panel = new System.Windows.Forms.Panel();
            this.AddContactButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.List_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_Panel
            // 
            this.List_Panel.Controls.Add(this.vScrollBar1);
            this.List_Panel.Controls.Add(this.AddContactButton);
            this.List_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Panel.Location = new System.Drawing.Point(0, 0);
            this.List_Panel.Name = "List_Panel";
            this.List_Panel.Size = new System.Drawing.Size(343, 613);
            this.List_Panel.TabIndex = 0;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddContactButton.BackColor = System.Drawing.Color.Transparent;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContactButton.BorderRadius = 0;
            this.AddContactButton.ButtonText = "Add Contact";
            this.AddContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddContactButton.DisabledColor = System.Drawing.Color.Gray;
            this.AddContactButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AddContactButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("AddContactButton.Iconimage")));
            this.AddContactButton.Iconimage_right = null;
            this.AddContactButton.Iconimage_right_Selected = null;
            this.AddContactButton.Iconimage_Selected = null;
            this.AddContactButton.IconMarginLeft = 0;
            this.AddContactButton.IconMarginRight = 0;
            this.AddContactButton.IconRightVisible = true;
            this.AddContactButton.IconRightZoom = 0D;
            this.AddContactButton.IconVisible = true;
            this.AddContactButton.IconZoom = 90D;
            this.AddContactButton.IsTab = false;
            this.AddContactButton.Location = new System.Drawing.Point(0, 0);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Normalcolor = System.Drawing.Color.Transparent;
            this.AddContactButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddContactButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddContactButton.selected = false;
            this.AddContactButton.Size = new System.Drawing.Size(343, 63);
            this.AddContactButton.TabIndex = 1;
            this.AddContactButton.Text = "Add Contact";
            this.AddContactButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddContactButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddContactButton.TextFont = new System.Drawing.Font("Century Gothic", 10F);
            this.AddContactButton.Visible = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(333, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 613);
            this.vScrollBar1.TabIndex = 2;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.List_Panel);
            this.Name = "ContactList";
            this.Size = new System.Drawing.Size(343, 613);
            this.List_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel List_Panel;
        public Bunifu.Framework.UI.BunifuFlatButton AddContactButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
