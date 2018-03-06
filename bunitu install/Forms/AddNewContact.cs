using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Database;
using AskholeLib;

namespace Askhole.Forms
{
    
    public partial class AddNewContact : Form
    {
        Dictionary<int, Lib.User> Contacts = new Dictionary<int, Lib.User>();
        Dictionary<int, Askhole.UserControls.UserButton> Buttons = new Dictionary<int, Askhole.UserControls.UserButton>();

        public AddNewContact()
        {
            InitializeComponent();
            userButton1.Select();
        }

        //public void RefreshButtons()
        //{
        //    if (Buttons.Count == 0)
        //        return;
        //    List_Panel.Controls.Clear();
        //    int idk = Buttons.Count * Buttons[0].Height - Buttons[0].Height;
        //    for (int i = 0; i < Buttons.Count; i++)
        //    {
        //        Buttons[i].Location = new Point(Buttons[i].Location.X, idk);
        //        idk -= Buttons[0].Height;
        //        List_Panel.Controls.Add(Buttons[i]);
        //    }
        //    //vScrollBar1.Scroll += (sender,e) =>{ List_Panel.VerticalScroll.Value = vScrollBar1.Value};
        //    List_Panel.VerticalScroll.Value = vScrollBar1.Value;
        //    //List_Panel.VerticalScroll.Value = List_Panel.VerticalScroll.Maximum;
        //}

        private void ForSearch_Leave(object sender, EventArgs e)
        {
            if (ForSearch.Text == "")  // перевірка чи щось було змінено
                ForSearch.Text = "User's name or email";

        }

        private void ForSearch_Enter(object sender, EventArgs e)
        {
            if (ForSearch.Text == "User's name or email")
                ForSearch.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForSearch_OnValueChanged(object sender, EventArgs e)
        {
            if (new EmailAddressAttribute().IsValid(ForSearch.Text))
            {
                DB.SearchByEmail(ForSearch.Text);
            }
            else
            {
                DB.SearchByName(ForSearch.Text);
            }
        }
    }
}
