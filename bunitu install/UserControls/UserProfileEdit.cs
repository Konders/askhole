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
using Database;

namespace Askhole
{
    public partial class UserProfileEdit : UserControl
    {
        public UserProfileEdit()
        {
            InitializeComponent();
            Name.Text = DB.user.username;
            var date = DB.user.birthDate;
            Date.Text = String.Format("{0:00}-{1:00}-{2:00}", date.Day, date.Month, date.Year);
            if (DB.user.photo != null)
                Photo.Image = DB.user.photo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(openFileDialog1.FileName);
                byte[] image = File.ReadAllBytes(openFileDialog1.FileName);
                Photo.Image = img;
            }
            
        }

        private void Date_Click(object sender, EventArgs e)
        {
            BirthDay.Visible = true;
        }

        private void BirthDay_onValueChanged(object sender, EventArgs e)
        {
            DateTime temp = BirthDay.Value;
            Date.Text = String.Format("{0:00}-{1:00}-{2:0000}", temp.Day, temp.Month, temp.Year);
            DB.ChangeBirthDay(temp);
            BirthDay.Visible = false;
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            DB.ChangeName(Name.Text);
        }
    }
}
