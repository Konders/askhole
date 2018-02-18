﻿using AskholeLib;
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
    public partial class ResetPassword : Form
    {
        private Sign_in signIn;
        public ResetPassword()
        {
            InitializeComponent();
            Confirm.Select(); // керування фокусом
        }
        public ResetPassword(Sign_in signIn)
        {
            InitializeComponent();
            this.signIn = signIn;
            Confirm.Select(); // керування фокусом
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.EnterText(temp);
        }

        private void LeaveChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.LeaveField(temp);
        }

        private void BackToSingIn_Click(object sender, EventArgs e)
        {
            Close();
            signIn.Show();
        }
    }
}
