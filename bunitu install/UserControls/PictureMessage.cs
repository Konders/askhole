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
        private int padding = 5;
        public int MessageWidth => pictureBox1.Width;

        public enum MessageType
        {
            In,
            Out
        }
        public PictureMessage()
        {
            InitializeComponent();
        }
        public PictureMessage(Bitmap img, string time)
        {
            InitializeComponent();
            pictureBox1.Image = img;
        }
        public PictureMessage(Bitmap img, string time, MessageType mt)
        {
            InitializeComponent();

            pictureBox1.Image = img;
            this.time.Text = time;
            AdjustSize();
            if (mt == MessageType.In)
                this.BackColor = Color.FromArgb(240, 240, 240);
            else
                this.BackColor = Color.FromArgb(147, 228, 241);
        }
        public void AdjustSize()
        {
            double ratio = 0;
            double maxpicwidth = 200;
            double maxpicheight = 200;
            Graphics g = CreateGraphics();
            time.Width = Convert.ToInt32(Math.Round(g.MeasureString(time.Text,
            time.Font, time.Width).Width + 2, 0));
            if (pictureBox1.Image.Width > pictureBox1.Image.Height)
                ratio = maxpicwidth / pictureBox1.Image.Width;
            else 
                ratio = maxpicheight / pictureBox1.Image.Height;


            double NewWidth =  ratio * pictureBox1.Image.Width;
            double NewHeight = ratio * pictureBox1.Image.Height;

            pictureBox1.Width = (int)NewWidth;
            pictureBox1.Height = (int)NewHeight;
            this.Height = (int)NewHeight;
            this.Width = (int)NewWidth;
            time.Top = pictureBox1.Bottom + padding;
            time.Left = pictureBox1.Width - time.Width + 25;
        }
    }
}
