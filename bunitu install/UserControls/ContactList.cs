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
        //Dictionary<int,UserButton>
        public ContactList()
        {
            InitializeComponent();
            Contacts.Add(0, new Lib.User(123,"Illya",null));
            Contacts.Add(1, new Lib.User(512, "Olya", null));
        }
        
        private void ContactList_MouseEnter(object sender, EventArgs e)
        {
            List_Panel.VerticalScroll.Value = List_Panel.VerticalScroll.Maximum;
        }
    }
}
