namespace Askhole.UserControls
{
    partial class Settings
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userProfileEdit1 = new Askhole.UserProfileEdit();
            this.LogOut = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeleteProfile = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // userProfileEdit1
            // 
            this.userProfileEdit1.BackColor = System.Drawing.Color.White;
            this.userProfileEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userProfileEdit1.Location = new System.Drawing.Point(0, 0);
            this.userProfileEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.userProfileEdit1.Name = "userProfileEdit1";
            this.userProfileEdit1.Size = new System.Drawing.Size(330, 161);
            this.userProfileEdit1.TabIndex = 9;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogOut.Location = new System.Drawing.Point(126, 212);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(73, 21);
            this.LogOut.TabIndex = 10;
            this.LogOut.Text = "Log out";
            this.LogOut.MouseLeave += new System.EventHandler(this.LogOut_MouseLeave);
            this.LogOut.MouseHover += new System.EventHandler(this.LogOut_MouseHover);
            // 
            // DeleteProfile
            // 
            this.DeleteProfile.AutoSize = true;
            this.DeleteProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DeleteProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteProfile.Location = new System.Drawing.Point(84, 176);
            this.DeleteProfile.Name = "DeleteProfile";
            this.DeleteProfile.Size = new System.Drawing.Size(160, 21);
            this.DeleteProfile.TabIndex = 10;
            this.DeleteProfile.Text = "Delete your profile";
            this.DeleteProfile.Click += new System.EventHandler(this.DeleteProfile_Click);
            this.DeleteProfile.MouseLeave += new System.EventHandler(this.DeleteProfile_MouseLeave);
            this.DeleteProfile.MouseHover += new System.EventHandler(this.DeleteProfile_MouseHover);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DeleteProfile);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.userProfileEdit1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(330, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserProfileEdit userProfileEdit1;
        private Bunifu.Framework.UI.BunifuCustomLabel LogOut;
        private Bunifu.Framework.UI.BunifuCustomLabel DeleteProfile;
    }
}
