using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bunitu_install
{
    public partial class UserProfileEdit : UserControl
    {
        public UserProfileEdit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] image = File.ReadAllBytes(openFileDialog1.FileName);
            }
        }
    }
}
