using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Askhole.UserControls
{
    public partial class Emoji : UserControl
    {
        public Emoji()
        {
            InitializeComponent();
        }
        /// <summary>
        /// натиснення на смайлик
        /// </summary>
        private void Emoji_Click(object sender, EventArgs e)
        {
            Chat.emoji = true; // закриваємо вікно
            Globals.mainForm.emoji1.Visible = false;
            var but = sender as BunifuImageButton; //отримуємо зображення з клавіші
            StringBuilder sb  =new StringBuilder(but.Name, 1, but.Name.Length-1, but.Name.Length);
            int key = Convert.ToInt32(sb.ToString());
            Clipboard.SetImage(imageList1.Images[key]);
            Globals.mainForm.chat1.Message.Paste();
            Globals.mainForm.chat1.Message.Rtf = AskholeLib.Lib.ChangeRTFsize(Globals.mainForm.chat1.Message.Rtf, 30, 30);//NOT WORKING 
        }

    }
}
