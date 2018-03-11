namespace Askhole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.Emoji = new Bunifu.Framework.UI.BunifuImageButton();
            this.Attach = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureMessage1 = new Askhole.UserControls.PictureMessage();
            this.messageBox1 = new Askhole.MessageBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attach)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Message);
            this.panel1.Controls.Add(this.Emoji);
            this.panel1.Controls.Add(this.Attach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 95);
            this.panel1.TabIndex = 0;
            // 
            // Message
            // 
            this.Message.AccessibleName = "Message";
            this.Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Message.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Message.Location = new System.Drawing.Point(101, 9);
            this.Message.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(705, 78);
            this.Message.TabIndex = 1;
            this.Message.Text = "Write a message...";
            this.Message.Enter += new System.EventHandler(this.Message_Enter);
            this.Message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Message_KeyDown);
            this.Message.Leave += new System.EventHandler(this.Message_Leave);
            // 
            // Emoji
            // 
            this.Emoji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Emoji.BackColor = System.Drawing.Color.Transparent;
            this.Emoji.Image = ((System.Drawing.Image)(resources.GetObject("Emoji.Image")));
            this.Emoji.ImageActive = ((System.Drawing.Image)(resources.GetObject("Emoji.ImageActive")));
            this.Emoji.Location = new System.Drawing.Point(817, 7);
            this.Emoji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Emoji.Name = "Emoji";
            this.Emoji.Size = new System.Drawing.Size(87, 80);
            this.Emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Emoji.TabIndex = 0;
            this.Emoji.TabStop = false;
            this.Emoji.Zoom = 10;
            this.Emoji.Click += new System.EventHandler(this.Emoji_Click);
            // 
            // Attach
            // 
            this.Attach.BackColor = System.Drawing.Color.Transparent;
            this.Attach.Image = ((System.Drawing.Image)(resources.GetObject("Attach.Image")));
            this.Attach.ImageActive = ((System.Drawing.Image)(resources.GetObject("Attach.ImageActive")));
            this.Attach.Location = new System.Drawing.Point(5, 9);
            this.Attach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(87, 80);
            this.Attach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attach.TabIndex = 0;
            this.Attach.TabStop = false;
            this.Attach.Zoom = 10;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.pictureMessage1);
            this.panel2.Controls.Add(this.messageBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 607);
            this.panel2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "angry.png");
            this.imageList1.Images.SetKeyName(1, "angry-1.png");
            this.imageList1.Images.SetKeyName(2, "bored.png");
            this.imageList1.Images.SetKeyName(3, "bored-1.png");
            this.imageList1.Images.SetKeyName(4, "bored-2.png");
            this.imageList1.Images.SetKeyName(5, "confused.png");
            this.imageList1.Images.SetKeyName(6, "confused-1.png");
            this.imageList1.Images.SetKeyName(7, "crying.png");
            this.imageList1.Images.SetKeyName(8, "crying-1.png");
            this.imageList1.Images.SetKeyName(9, "embarrassed.png");
            this.imageList1.Images.SetKeyName(10, "emoticons.png");
            this.imageList1.Images.SetKeyName(11, "happy.png");
            this.imageList1.Images.SetKeyName(12, "happy-1.png");
            this.imageList1.Images.SetKeyName(13, "happy-2.png");
            this.imageList1.Images.SetKeyName(14, "happy-3.png");
            this.imageList1.Images.SetKeyName(15, "happy-4.png");
            this.imageList1.Images.SetKeyName(16, "ill.png");
            this.imageList1.Images.SetKeyName(17, "in-love.png");
            this.imageList1.Images.SetKeyName(18, "kissing.png");
            this.imageList1.Images.SetKeyName(19, "mad.png");
            this.imageList1.Images.SetKeyName(20, "nerd.png");
            this.imageList1.Images.SetKeyName(21, "ninja.png");
            this.imageList1.Images.SetKeyName(22, "quiet.png");
            this.imageList1.Images.SetKeyName(23, "sad.png");
            this.imageList1.Images.SetKeyName(24, "secret.png");
            this.imageList1.Images.SetKeyName(25, "smart.png");
            this.imageList1.Images.SetKeyName(26, "smile.png");
            this.imageList1.Images.SetKeyName(27, "smiling.png");
            this.imageList1.Images.SetKeyName(28, "surprised.png");
            this.imageList1.Images.SetKeyName(29, "surprised-1.png");
            this.imageList1.Images.SetKeyName(30, "suspicious.png");
            this.imageList1.Images.SetKeyName(31, "suspicious-1.png");
            this.imageList1.Images.SetKeyName(32, "tongue-out.png");
            this.imageList1.Images.SetKeyName(33, "tongue-out-1.png");
            this.imageList1.Images.SetKeyName(34, "unhappy.png");
            this.imageList1.Images.SetKeyName(35, "wink.png");
            // 
            // pictureMessage1
            // 
            this.pictureMessage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.pictureMessage1.Location = new System.Drawing.Point(5, 71);
            this.pictureMessage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureMessage1.Name = "pictureMessage1";
            this.pictureMessage1.Size = new System.Drawing.Size(395, 309);
            this.pictureMessage1.TabIndex = 1;
            // 
            // messageBox1
            // 
            this.messageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.messageBox1.Location = new System.Drawing.Point(5, 4);
            this.messageBox1.Margin = new System.Windows.Forms.Padding(5);
            this.messageBox1.Name = "messageBox1";
            this.messageBox1.Size = new System.Drawing.Size(395, 69);
            this.messageBox1.TabIndex = 0;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(908, 702);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Emoji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Attach;
        public System.Windows.Forms.RichTextBox Message;
        private Bunifu.Framework.UI.BunifuImageButton Emoji;
        private MessageBox messageBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private UserControls.PictureMessage pictureMessage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}
