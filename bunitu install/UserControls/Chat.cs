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

namespace Askhole
{
    public partial class Chat : UserControl
    {
       
            public Chat()
        {
            if(!this.DesignMode)
            InitializeComponent();
            messageBox1.Hide();
            Message_Old = messageBox1;          
        }
        MessageBox Message_Old = new MessageBox();

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
            msg.Size = messageBox1.Size;
            msg.Anchor = messageBox1.Anchor;
            msg.Top = Message_Old.Bottom + 10;
            //Якщо це твоє повідомлення, то зміщуємо його в протележну сторону
            if (mt == MessageBox.MessageType.Out)
                msg.Left = (Size.Width - msg.MessageWidth) - 40; 

            panel2.Controls.Add(msg);
            Message_Old = msg;
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
                string time = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute +".");
                AddMessage(Message.Text, time, MessageBox.MessageType.Out);
                AddMessage(Message.Text, time, MessageBox.MessageType.In);
                panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;//Добавляємо скроллінг
                DB.AddMessageText(Message.Text, MessageTime);
            }
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                //teststuff
                Globals.mainForm.contactList1.AddContact(3, "test", bitmap);
            }
        }
    }
}
