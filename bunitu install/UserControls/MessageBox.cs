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
        private int padding = 5;
        public MessageBox()
        {
            InitializeComponent();
        }
        public enum MessageType
        {
            In,
            Out
        }
        /// <summary>
        /// Конструктор повідомлення
        /// </summary>
        /// <param name="text">Вміст повідомлення</param>
        /// <param name="time">Момент відправки повідомлення</param>
        /// <param name="mt">In(Вхідне), Out(Вихідне)</param>
        public MessageBox(string text, string time,MessageType mt)
        {
            InitializeComponent();

            message.Text = text;
            this.time.Text = time;
            AdjustHeight();
            if(mt == MessageType.In)
                this.BackColor = Color.FromArgb(240, 240, 240);
            else
                this.BackColor = Color.FromArgb(147, 228, 241);
        }
        /// <summary>
        /// Змінюємо розміри поля з повідомленням
        /// </summary>
        void AdjustHeight()
        {
            Size maxSize = new Size(message.Width, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(message.Text, message.Font, message.Width);
            message.Height = Convert.ToInt32(Math.Round(size.Height + 2, 0));
            time.Top = message.Bottom + padding;
            time.Left = message.Width - int.Parse(Math.Round(g.MeasureString(time.Text, time.Font, time.Width).Width + 2,0).ToString()) + 30;
            time.Width = int.Parse(Math.Round(g.MeasureString(time.Text, time.Font, time.Width).Width + 2, 0).ToString());
            this.Height = time.Bottom + padding;
        }

        private void MessageBox_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
