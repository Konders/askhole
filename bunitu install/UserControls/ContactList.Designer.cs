namespace bunitu_install
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
            this.List_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // List_Panel
            // 
            this.List_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Panel.Location = new System.Drawing.Point(0, 0);
            this.List_Panel.Name = "List_Panel";
            this.List_Panel.Size = new System.Drawing.Size(343, 613);
            this.List_Panel.TabIndex = 0;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.List_Panel);
            this.Name = "ContactList";
            this.Size = new System.Drawing.Size(343, 613);
            this.MouseEnter += new System.EventHandler(this.ContactList_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel List_Panel;
    }
}
