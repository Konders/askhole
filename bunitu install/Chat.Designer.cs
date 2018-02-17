﻿namespace bunitu_install
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Message = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Emoji = new Bunifu.Framework.UI.BunifuImageButton();
            this.Attach = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Message);
            this.panel1.Controls.Add(this.Emoji);
            this.panel1.Controls.Add(this.Attach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 77);
            this.panel1.TabIndex = 0;
            // 
            // Message
            // 
            this.Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Message.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Message.HintForeColor = System.Drawing.Color.Empty;
            this.Message.HintText = "";
            this.Message.isPassword = false;
            this.Message.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Message.LineIdleColor = System.Drawing.Color.Gray;
            this.Message.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Message.LineThickness = 3;
            this.Message.Location = new System.Drawing.Point(76, 7);
            this.Message.Margin = new System.Windows.Forms.Padding(4);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(530, 62);
            this.Message.TabIndex = 1;
            this.Message.Text = "Write a message...";
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Emoji
            // 
            this.Emoji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Emoji.BackColor = System.Drawing.Color.Transparent;
            this.Emoji.Image = ((System.Drawing.Image)(resources.GetObject("Emoji.Image")));
            this.Emoji.ImageActive = ((System.Drawing.Image)(resources.GetObject("Emoji.ImageActive")));
            this.Emoji.Location = new System.Drawing.Point(613, 6);
            this.Emoji.Name = "Emoji";
            this.Emoji.Size = new System.Drawing.Size(65, 65);
            this.Emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Emoji.TabIndex = 0;
            this.Emoji.TabStop = false;
            this.Emoji.Zoom = 10;
            // 
            // Attach
            // 
            this.Attach.BackColor = System.Drawing.Color.Transparent;
            this.Attach.Image = ((System.Drawing.Image)(resources.GetObject("Attach.Image")));
            this.Attach.ImageActive = ((System.Drawing.Image)(resources.GetObject("Attach.ImageActive")));
            this.Attach.Location = new System.Drawing.Point(4, 7);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(65, 65);
            this.Attach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attach.TabIndex = 0;
            this.Attach.TabStop = false;
            this.Attach.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 493);
            this.panel2.TabIndex = 1;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(681, 570);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Emoji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Attach;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Message;
        private Bunifu.Framework.UI.BunifuImageButton Emoji;
    }
}