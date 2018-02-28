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
    public partial class UserButton : UserControl
    {
        public UserButton()
        {
            InitializeComponent();
        }
        public UserButton(AskholeLib.Lib.User obj)
        {
            InitializeComponent();

            UserName.Text = obj.username;
            if (obj.photo != null)
                UserName.Iconimage = obj.photo;
        }
        public UserButton(string name, Bitmap photo)
        {
            InitializeComponent();

            UserName.Text = name;
            if (photo != null)
                UserName.Iconimage = photo;
        }
        public UserButton(string name)
        {
            InitializeComponent();

            UserName.Text = name;
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            if (UserName.Text != Globals.mainForm.contactList1.AddContactButton.Text)
            {
                DB.RecieverName = UserName.Text;

                //MainForm.NameU = DB.RecieverName;
                Globals.mainForm.ChangeName(UserName.Text, UserName.Iconimage);
            }
        }
    }
}
