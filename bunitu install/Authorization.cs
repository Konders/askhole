using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunitu_install
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Signup.Select();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Sign_in signIn = new Sign_in();
            this.Hide();            
            signIn.Show();
        }
        private void EnterChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (temp.Text == temp.Name)
                temp.Text = "";
        }

        private void LeaveChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (temp.Text == "")
                temp.Text = temp.Name;
        }

        private void Passconfirm_Enter(object sender, EventArgs e)
        {
            string text = "Password confirmation";
            if (text == Passconfirm.Text)
                Passconfirm.Text = "";
        }

        private void Passconfirm_Leave(object sender, EventArgs e)
        {
            if (Passconfirm.Text == "")
                Passconfirm.Text = "Password confirmation";
        }
    }
}
