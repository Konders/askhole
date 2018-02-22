namespace Askhole
{
    partial class MessageBox
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
            this.message = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.message.Location = new System.Drawing.Point(15, 11);
            this.message.Name = "label1";
            this.message.Size = new System.Drawing.Size(419, 87);
            this.message.TabIndex = 0;
            this.message.Text = "label1";
            // 
            // label2
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.time.Location = new System.Drawing.Point(15, 42);
            this.time.Name = "label2";
            this.time.Size = new System.Drawing.Size(63, 18);
            this.time.TabIndex = 0;
            this.time.Text = "6:13 PM";
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.time);
            this.Controls.Add(this.message);
            this.Name = "MessageBox";
            this.Size = new System.Drawing.Size(450, 109);
            this.Resize += new System.EventHandler(this.MessageBox_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label time;
    }
}
