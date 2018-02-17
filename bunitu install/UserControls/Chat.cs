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
            //Якщо це твоє повідомлення, то зміщуємо його на 20 пікселів
            if (mt == MessageBox.MessageType.Out)
                msg.Left += 20;

            panel2.Controls.Add(msg);
            Message_Old = msg;
        }
        /// <summary>
        /// Відправка повідомлення на Key Enter
        /// </summary>
        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMessage(Message.Text, "7:09 PM", MessageBox.MessageType.Out);
                AddMessage(Message.Text, "7:09 PM", MessageBox.MessageType.In);
                panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;//Добавляємо скроллінг
            }
        }
    }
}
