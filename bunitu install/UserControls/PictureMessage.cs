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
            AdjustHeight();
            if (mt == MessageType.In)
                this.BackColor = Color.FromArgb(240, 240, 240);
            else
            {
                this.BackColor = Color.FromArgb(147, 228, 241);
            }
        }
        void AdjustHeight()
        {
            Graphics g = CreateGraphics();
            time.Width = Convert.ToInt32(Math.Round(g.MeasureString(time.Text,
                                            time.Font, time.Width).Width + 2, 0));
            Size maxSize = new Size(pictureBox1.Width, int.MaxValue);
            pictureBox1.Height = pictureBox1.Size.Height + 2;
            time.Top = pictureBox1.Bottom + padding;
            time.Left = pictureBox1.Width - time.Width + 25;
            Height = time.Bottom + padding;
        }
    }
}
