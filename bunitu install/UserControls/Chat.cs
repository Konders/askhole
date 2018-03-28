using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Database;
using Askhole.UserControls;
using System.Threading;

namespace Askhole
{
    public partial class Chat : UserControl
    {
        private Thread ResizeThread;
        int message_padding = 10;
            public Chat()
        {
            if(!this.DesignMode)
            InitializeComponent();
            messageBox1.Hide();
            pictureMessage1.Hide();     
        }
       
        /// <summary>
        /// Додаємо повідомлення
        /// </summary>
        /// <param name="text">Вміст повідомлення</param>
        /// <param name="time">Момент відправки повідомлення</param>
        /// <param name="mt">In(Вхідне), Out(Вихідне)</param>
        public void AddMessage(string text, string time, MessageBox.MessageType mt)
        {
            MessageBox msg = new MessageBox(text, time, mt);
            msg.Location = messageBox1.Location;
            msg.Anchor = messageBox1.Anchor;
            msg.Top = panel2.Controls[panel2.Controls.Count - 1].Bottom + message_padding;
            //Якщо це твоє повідомлення, то зміщуємо його в протележну сторону
            if (mt == MessageBox.MessageType.Out)
                msg.Left = (Size.Width - msg.MessageWidth) - 40; 

            panel2.Controls.Add(msg);
        }

        /// <summary>
        /// При наведені на текстове поле стирається початкова інформація
        /// </summary>
        private void Message_Enter(object sender, EventArgs e)
        {
            string text = "Write a message...";
            if (text == Message.Text)
                Message.Text = "";
        }
        /// <summary>
         /// При відведені курсору з текстового поля вертається назва поля
         /// </summary>
        private void Message_Leave(object sender, EventArgs e)
        {
            if (Message.Text == "")
                Message.Text = "Write a message...";
        }
        /// <summary>
        /// Відправка повідомлення на Key Enter
        /// </summary>
        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateTime MessageTime = new DateTime();// поточний час
                MessageTime = DateTime.Now;
                string time = MessageTime.ToShortTimeString();//Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute +".");
                AddMessage(Message.Text, time, MessageBox.MessageType.Out);
                AddMessage(Message.Text, time, MessageBox.MessageType.In);
                panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;//Добавляємо скроллінг
                DB.AddMessageText(Message.Text, MessageTime); //Laggy connection
            }
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                DateTime MessageTime = new DateTime();// поточний час
                MessageTime = DateTime.Now;
                string time = MessageTime.ToShortTimeString();//Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ".");
                AddPhoto(bitmap, time, PictureMessage.MessageType.Out);
                //teststuff
                //Globals.mainForm.contactList1.AddContact(3, "test", bitmap);
            }
        }

        public void AddPhoto(Bitmap img, string time, PictureMessage.MessageType mt)
        {
            PictureMessage msg = new PictureMessage(img, time, mt);
            msg.Location = messageBox1.Location;
            //msg.Size = messageBox1.Size;
            msg.Anchor = messageBox1.Anchor;
            msg.Top = panel2.Controls[panel2.Controls.Count - 1].Bottom + message_padding;
            if (mt == PictureMessage.MessageType.Out)
                msg.Left = (Size.Width - msg.MessageWidth) - 40;
            panel2.Controls.Add(msg);
        }
        static public bool emoji = true;
        private void Emoji_Click(object sender, EventArgs e)
        {
            if (emoji)
            {
                Globals.mainForm.emoji1.Visible = true;
                emoji = false;
            }
            else
            {
                Globals.mainForm.emoji1.Visible = false;
                emoji = true;
            }
        }
        private void Resize()
        {
            for(int i = 1;i<panel2.Controls.Count;i++)
            {
                if (panel2.Controls[i].GetType() == typeof(MessageBox))
                    (panel2.Controls[i] as MessageBox).AdjustHeight();
                else if (panel2.Controls[i].GetType() == typeof(PictureBox))
                    (panel2.Controls[i] as PictureMessage).AdjustSize();
                panel2.Controls[i].Top = panel2.Controls[i - 1].Bottom + message_padding;
            }
        }

        public void threadresize()
        {
            ResizeThread = new Thread(this.Resize);
            ResizeThread.Start();
        }
        private void panel2_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
