using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askhole.UserControls
{
    public partial class PictureMessage : UserControl
    {
        public PictureMessage()
        {
            InitializeComponent();
        }
        public PictureMessage(Bitmap img, string time)
        {
            InitializeComponent();
            pictureBox1.Image = img;
        }
    }
}
