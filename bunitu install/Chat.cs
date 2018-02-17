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
            /*ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { panel2.VerticalScroll.Value = vScrollBar1.Value; };
            panel2.Controls.Add(vScrollBar1);*/
        }
        public int topmessage = 10;
        public int lastmessage = 0;
        MessageBox Message_Old = new MessageBox();

        public void AddMessage(string text, string time, MessageBox.MessageType mt)
        {
            MessageBox msg = new MessageBox(text, time, mt);
            msg.Location = messageBox1.Location;
            msg.Size = messageBox1.Size;
            msg.Anchor = messageBox1.Anchor;
            msg.Top = Message_Old.Bottom + 10;
            if (mt == MessageBox.MessageType.Out)
                msg.Left += 20;


           // topmessage = msg.Bottom + 10;
            panel2.Controls.Add(msg);

            //panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

            Message_Old = msg;
        }

        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMessage(Message.Text, "7:09 PM", MessageBox.MessageType.Out);
                AddMessage(Message.Text, "7:09 PM", MessageBox.MessageType.In);
                panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            }
        }

     
    }
}
