using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskholeLib;

namespace bunitu_install
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Signup.Select(); // керування фокусом
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
   
        /// <summary>
        /// Активізація форми на реєстрацію
        /// </summary>
        private void Signup_Click(object sender, EventArgs e)
        {
            Sign_in signIn = new Sign_in();
            this.Hide();            // приховуємо початкову форму
            signIn.Show();          // виводимо форму реєстрації
        }
     
        /// <summary>
        /// При наведені на текстове поле стирається початкова інформація
        /// </summary>
        private void EnterChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.EnterText(temp);

        }

        /// <summary>
        /// При відведені курсору з текстового поля вертається назва поля
        /// </summary>
        private void LeaveChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.LeaveField(temp);               
        }

        /// <summary>
        /// При наведені на текстове поле стирається початкова інформація
        /// </summary>
        private void Passconfirm_Enter(object sender, EventArgs e)
        {
            string text = "Password confirmation";
            if (text == Passconfirm.Text)
            {
                Passconfirm.Text = "";
                Passconfirm.isPassword = true;
            }
        }
        /// <summary>
        /// При відведені курсору з текстового поля вертається назва поля
        /// </summary>
        private void Passconfirm_Leave(object sender, EventArgs e)
        {
            if (Passconfirm.Text == "")
            {
                Passconfirm.Text = "Password confirmation";
                Passconfirm.isPassword = false;
            }
        }
        //Переходимо у форму авторизації
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            Sign_in.ActiveForm.Show();
            Authorization.ActiveForm.Close();
        }
    }
}
