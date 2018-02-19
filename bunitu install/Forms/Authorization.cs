using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private Sign_in signIn;
        SqlConnection cn;
        SqlCommand cmd;

        public Authorization()
        {
            InitializeComponent();
            Signup.Select(); // керування фокусом
        }
        public Authorization(Sign_in signIn, SqlConnection cn, SqlCommand cmd)
        {
            InitializeComponent();
            Signup.Select(); // керування фокусом
            this.signIn = signIn;
            this.cn = cn; // з'єднання з ЬД
            this.cmd = cmd;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Активізація форми на реєстрацію
        /// </summary>
        private void Signup_Click(object sender, EventArgs e)
        {
            // неправильний формат вхідних данних
            if (!Lib.Spelling(Username.Text, Password.Text, ErrorName,ErrorPassword))
                return;
            
            if (Password.Text != Passconfirm.Text)// чи співдалають паролі
            {
                Confirmation.ForeColor = Color.Red;
                return;             
            }
            else Confirmation.ForeColor = Color.FromArgb(248, 248, 248);
            NewUser();                  // приховуємо початкову форму
           
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
        private void BackToSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            signIn.Show();
        }

        private void NewUser()
        {
            try
            {
                cn.Open();
                var email = (Email.Text == Email.Name) ? null : Email.Text;
                                
                 StringBuilder comand = new StringBuilder("exec AddUser '" + Username.Text + "', '" +
                               Password.Text + "', '"+ email + "', '"+ birthDay.Value + "'");
                cmd.CommandText = Convert.ToString(comand);
                cmd.ExecuteNonQuery();
                Hide();
                MainForm mainForm = new MainForm(); // форма з повідомленнями
                mainForm.Show();
                cn.Close();
                Error.ForeColor = Color.FromArgb(248, 248, 248); // вертаємо колір помилки
            }
            catch (SqlException ex)
            {
                Error.ForeColor = Color.Red; // вертаємо колір помилки
                cn.Close();
            }
        }
    }
}
