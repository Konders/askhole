using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunitu_install
{
    public partial class MessageBox : UserControl
    {
        public MessageBox()
        {
            InitializeComponent();
        }
        public enum MessageType
        {
            In,
            Out
        }
        public MessageBox(string text, string time,MessageType mt)
        {
            InitializeComponent();
            label1.Text = text;
            label2.Text = time;
            AdjustHeight();
            if(mt == MessageType.In)
                this.BackColor = Color.FromArgb(240, 240, 240);
            else
                this.BackColor = Color.FromArgb(147, 228, 241);
        }

        void AdjustHeight()
        {
            Size maxSize = new Size(label1.Width, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(label1.Text, label1.Font, label1.Width);

            label1.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            label2.Top = label1.Bottom + 5;
            label2.Left = label1.Width - int.Parse(Math.Round(g.MeasureString(label2.Text, label2.Font, label2.Width).Width + 2,0).ToString()) + 30;
            label2.Width = int.Parse(Math.Round(g.MeasureString(label2.Text, label2.Font, label2.Width).Width + 2, 0).ToString());
            this.Height = label2.Bottom + 5;
        }

        private void MessageBox_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
