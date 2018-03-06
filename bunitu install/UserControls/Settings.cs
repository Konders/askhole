using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace Askhole.UserControls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void DeleteProfile_MouseHover(object sender, EventArgs e)
        {
            DeleteProfile.ForeColor = Color.FromArgb(147, 228, 241);
        }

        private void LogOut_MouseHover(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.FromArgb(147, 228, 241);
        }

        private void DeleteProfile_MouseLeave(object sender, EventArgs e)
        {
            DeleteProfile.ForeColor = Color.FromArgb(64, 64, 64);
    }

        private void LogOut_MouseLeave(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.FromArgb(64, 64, 64);

        }

        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            DB.DeleteProfile();
            Application.Restart();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DB.LogOut();
            Application.Restart();
        }
    }
}
