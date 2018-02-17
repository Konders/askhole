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
    public partial class ContactList : UserControl
    {
        Dictionary<int, string> Contacts = new Dictionary<int, string>();
        public ContactList()
        {
            InitializeComponent();
            Contacts.Add(0, "Illya");
        }
        
        private void ContactList_MouseEnter(object sender, EventArgs e)
        {
            List_Panel.VerticalScroll.Value = List_Panel.VerticalScroll.Maximum;
        }
    }
}
