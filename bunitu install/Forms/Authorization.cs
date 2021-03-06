﻿using System;
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
using Database;

namespace Askhole
{
    public partial class Authorization : Form
    {
        private Sign_in signIn;

        public Authorization()
        {
            InitializeComponent();
            Signup.Select(); // керування фокусом
        }
        public Authorization(Sign_in signIn)
        {
            InitializeComponent();
            Signup.Select(); // керування фокусом
            this.signIn = signIn;
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
            if (!Lib.Spelling(Username.Text, Password.Text, ErrorName,ErrorPassword)) return;
            // чи співпадають паролі
            if (!Lib.ConfirmPassword(Password.Text, Passconfirm.Text, Confirmation))  return;
            // чи є емейл
            if (!Lib.CheckEmail(Email.Text, ErrorEmail))  return;
            
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
        // Перевірка пароля
        private void Passconfirm_Enter(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.EnterConfirm(temp);
        }
        /// <summary>
        /// При відведені курсору з текстового поля вертається назва поля
        /// </summary>
        private void LeaveChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.LeaveField(temp);
        }
        // для перевірки пароля
        private void Passconfirm_Leave(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            Lib.LeaveConfirm(temp);
        }


        //Переходимо у форму авторизації
        private void BackToSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            signIn.Show();
        }
        /// <summary>
        /// Створення новго користувача
        /// </summary>
        private void NewUser()
        {
            var email = (Email.Text == Email.Name) ? null : Email.Text;
            if (DB.NewUser(Username.Text, Password.Text, email, birthDay.Value))
            {
                Hide();
                //MainForm mainForm = new MainForm(); // форма з повідомленнями
                Globals.mainForm = new MainForm();
                Globals.mainForm.Show();
                Error.Visible = false; // вертаємо колір помилки
            }
            else Error.Visible = true; // вертаємо колір помилки
         
        }
    }
}
