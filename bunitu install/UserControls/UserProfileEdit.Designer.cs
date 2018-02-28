namespace Askhole
{
    partial class UserProfileEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileEdit));
            this.label3 = new System.Windows.Forms.Label();
            this.BirthDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(174, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthday: ";
            // 
            // BirthDay
            // 
            this.BirthDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.BirthDay.BorderRadius = 0;
            this.BirthDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BirthDay.ForeColor = System.Drawing.Color.White;
            this.BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthDay.FormatCustom = null;
            this.BirthDay.Location = new System.Drawing.Point(164, 109);
            this.BirthDay.Margin = new System.Windows.Forms.Padding(5);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(156, 26);
            this.BirthDay.TabIndex = 6;
            this.BirthDay.Value = new System.DateTime(2018, 2, 16, 0, 0, 0, 0);
            this.BirthDay.Visible = false;
            this.BirthDay.onValueChanged += new System.EventHandler(this.BirthDay_onValueChanged);
            // 
            // Name
            // 
            this.Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.HintForeColor = System.Drawing.Color.Empty;
            this.Name.HintText = "";
            this.Name.isPassword = false;
            this.Name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Name.LineIdleColor = System.Drawing.Color.Gray;
            this.Name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.Name.LineThickness = 3;
            this.Name.Location = new System.Drawing.Point(178, 5);
            this.Name.Margin = new System.Windows.Forms.Padding(5);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(132, 41);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Photo
            // 
            this.Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(4, 0);
            this.Photo.Margin = new System.Windows.Forms.Padding(4);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(151, 135);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 2;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Date.Location = new System.Drawing.Point(174, 84);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(83, 20);
            this.Date.TabIndex = 8;
            this.Date.Text = "01-01-1900";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // UserProfileEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Photo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(337, 161);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Photo;
        private Bunifu.Framework.UI.BunifuDatepicker BirthDay;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Date;
    }
}
