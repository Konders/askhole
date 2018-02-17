using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunitu_install.UserControls
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

      
    }
}
