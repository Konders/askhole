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
namespace bunitu_install
{
    public partial class ContactList : UserControl
    {
        Dictionary<int, Lib.User> Contacts = new Dictionary<int, Lib.User>();
        Dictionary<int, bunitu_install.UserControls.UserButton> Buttons = new Dictionary<int, bunitu_install.UserControls.UserButton>();
        public ContactList()
        {
            InitializeComponent();
            //Contacts.Add(0, new Lib.User(123,"Illya",null));
            //Contacts.Add(1, new Lib.User(512, "Olya", null));
        }
        public void AddContact(int id,string name)
        {
            //select * from users where id = @id
            Contacts.Add(Contacts.Count, new Lib.User(id, name, null));
            Buttons.Add(Contacts.Count-1 , new bunitu_install.UserControls.UserButton(Contacts[Contacts.Count-1]));
            Buttons[Contacts.Count - 1].Location = AddContactButton.Location;
            Buttons[Contacts.Count - 1].Size = AddContactButton.Size;
            Buttons[Contacts.Count - 1].Anchor = AddContactButton.Anchor;
            List_Panel.Controls.Add(Buttons[Contacts.Count - 1]);
            AddContactButton.Top += Buttons[0].Height;

        }
        private void ContactList_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact(0, "Illya");
            AddContact(1, "Olya");
            List_Panel.VerticalScroll.Value = List_Panel.VerticalScroll.Maximum;
        }
    }
}
