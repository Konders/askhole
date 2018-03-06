using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askhole.Forms
{
    public partial class AddNewContact : Form
    {
        public AddNewContact()
        {
            InitializeComponent();
            userButton1.Select();
        }

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
    }
}
