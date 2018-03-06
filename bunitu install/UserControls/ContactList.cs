using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskholeLib;
using Askhole.Forms;

namespace Askhole
{
    public partial class ContactList : UserControl
    {
        Dictionary<int, Lib.User> Contacts = new Dictionary<int, Lib.User>();
        Dictionary<int, Askhole.UserControls.UserButton> Buttons = new Dictionary<int, Askhole.UserControls.UserButton>();
        public void RefreshButtons()
        {
            if (Buttons.Count == 0)
                return;
            List_Panel.Controls.Clear();
            int idk = Buttons.Count * Buttons[0].Height - Buttons[0].Height;
            for(int i = 0;i<Buttons.Count;i++)
            {
                Buttons[i].Location = new Point(Buttons[i].Location.X,idk);
                idk -= Buttons[0].Height;
                List_Panel.Controls.Add(Buttons[i]);
            }
            //vScrollBar1.Scroll += (sender,e) =>{ List_Panel.VerticalScroll.Value = vScrollBar1.Value};
            List_Panel.VerticalScroll.Value = vScrollBar1.Value;
            //List_Panel.VerticalScroll.Value = List_Panel.VerticalScroll.Maximum;
        }
        public ContactList()
        {
            InitializeComponent();
            //Contacts.Add(0, new Lib.User(123,"Illya",null));
            //Contacts.Add(1, new Lib.User(512, "Olya", null));
            Buttons.Add(0, new Askhole.UserControls.UserButton());
            Buttons[0].Location = AddContactButton.Location;
            Buttons[0].Size = AddContactButton.Size;
            Buttons[0].Anchor = AddContactButton.Anchor;
            Buttons[0].UserName.Iconimage = AddContactButton.Iconimage;
            Buttons[0].UserName.Text = AddContactButton.Text;
            Buttons[0].UserName.Click += AddContactButton_Click;
            List_Panel.Controls.Add(Buttons[0]);
            //Buttons[0].
        }
        public void AddContact(int id, string name,  byte[] img)
        {
            //select * from users where id = @id
            Contacts.Add(Contacts.Count, new Lib.User(id, name, null, AskholeLib.Lib.ByteArrayToImage(img)));
            Buttons.Add(Contacts.Count, new Askhole.UserControls.UserButton(Contacts[Contacts.Count - 1]));
            Buttons[Contacts.Count - 1].Location = AddContactButton.Location;
            Buttons[Contacts.Count - 1].Size = AddContactButton.Size;
            Buttons[Contacts.Count - 1].Anchor = AddContactButton.Anchor;
            RefreshButtons();
            //List_Panel.Controls.Add(Buttons[Contacts.Count - 1]);
            //AddContactButton.Top += Buttons[0].Height;

        }
        public void AddContact(int id, string name,  Bitmap img)
        {
            //select * from users where id = @id
            Contacts.Add(Contacts.Count, new Lib.User(id, name, null,  img));
            Buttons.Add(Contacts.Count, new Askhole.UserControls.UserButton(Contacts[Contacts.Count - 1]));
            Buttons[Contacts.Count - 1].Location = AddContactButton.Location;
            Buttons[Contacts.Count - 1].Size = AddContactButton.Size;
            Buttons[Contacts.Count - 1].Anchor = AddContactButton.Anchor;
            RefreshButtons();
            //List_Panel.Controls.Add(Buttons[Contacts.Count - 1]);
            //AddContactButton.Top += Buttons[0].Height;

        }
        public void AddContact(int id,string name)
        {
            //select * from users where id = @id
            Contacts.Add(Contacts.Count, new Lib.User(id, name, null));
            Buttons.Add(Contacts.Count , new Askhole.UserControls.UserButton(Contacts[Contacts.Count-1]));
            Buttons[Contacts.Count - 1].Location = AddContactButton.Location;
            Buttons[Contacts.Count - 1].Size = AddContactButton.Size;
            Buttons[Contacts.Count - 1].Anchor = AddContactButton.Anchor;
            RefreshButtons();
            //List_Panel.Controls.Add(Buttons[Contacts.Count - 1]);
            //AddContactButton.Top += Buttons[0].Height;

        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
           // AddContact(0, "Illya");
           // AddContact(1, "Olya");
            AddNewContact addC = new AddNewContact();
            addC.Show();
        }
    }
}
