using AskholeLib;
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

namespace bunitu_install
{
    public partial class ResetPassword : Form
    {
        private Sign_in signIn;
        SqlConnection cn;
        SqlCommand cmd;

        public ResetPassword()
        {
            InitializeComponent();
            Confirm.Select(); // керування фокусом
        }
        public ResetPassword(Sign_in signIn, SqlConnection cn, SqlCommand cmd)
        {
            InitializeComponent();
            this.signIn = signIn;
            Confirm.Select(); // керування фокусом
            this.cn = cn; // з'єднання з ЬД
            this.cmd = cmd;
        }
        // повернення назад до форми входу
        private void Close_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Hide();
            signIn.Show();
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


        private void Confirm_Click(object sender, EventArgs e)
        {
            // перевірка чи імена не є початковими
            if ((Password.Text == Password.Name) && (Username.Text == Username.Name)) return;
            // неправильний формат вхідних данних
            if (!Lib.Spelling(Username.Text, Password.Text, ErrorName, ErrorPassword)) return;
            // чи співпадають паролі
            // чи є емейл
            if (Lib.CheckEmail(Email.Text, ErrorEmail)) return;

            if (!Lib.ConfirmPassword(Password.Text, Passconfirm.Text, Confirmation)) return;

            try
            {
                cn.Open();
                StringBuilder str = new StringBuilder("exec ToResetPassword '" + Username.Text + "', '" +
                                                        Email.Text + "', '" + Passconfirm.Text + "'");
                cmd.CommandText = Convert.ToString(str);
                cmd.ExecuteNonQuery();
                this.Hide();
                MainForm mainForm = new MainForm(); // форма з повідомленнями
                mainForm.Show();
                cn.Close();
                Error.Hide(); // вертаємо колір помилки
            }
            catch (SqlException ex)
            {
                Error.Show(); // вертаємо колір помилки
                cn.Close();
            }
        }
        // для перевірки пароля
        private void LeaveConfirm(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.LeaveConfirm(temp);
        }
        // Перевірка пароля
        private void EnterConfirm(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.EnterConfirm(temp);
        }
    }
}
