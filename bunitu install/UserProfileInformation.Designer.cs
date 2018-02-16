namespace bunitu_install
{
    partial class UserProfileInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileInformation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name = new System.Windows.Forms.Label();
            this.online = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.Label();
            this.offline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(177, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(58, 21);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.online.ForeColor = System.Drawing.Color.DodgerBlue;
            this.online.Location = new System.Drawing.Point(182, 51);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(47, 17);
            this.online.TabIndex = 1;
            this.online.Text = "online";
            this.online.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birthday: ";
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdate.Location = new System.Drawing.Point(102, 178);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(96, 21);
            this.birthdate.TabIndex = 1;
            this.birthdate.Text = "01/01/1990";
            // 
            // offline
            // 
            this.offline.AutoSize = true;
            this.offline.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.offline.ForeColor = System.Drawing.Color.Firebrick;
            this.offline.Location = new System.Drawing.Point(182, 51);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(47, 17);
            this.offline.TabIndex = 1;
            this.offline.Text = "offline";
            this.offline.Visible = false;
            // 
            // UserProfileInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.online);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.offline);
            //this.Name = "UserProfileInformation";
            this.Size = new System.Drawing.Size(283, 230);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Label offline;
    }
}
