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
    public partial class Sign_in : Form
    {
        #region Variables
        private string password;
        private string username;
        #endregion

        #region Constructor
        public Sign_in()
        {
            InitializeComponent();
            Enter.Select(); // керування фокусом
        }
        #endregion

        // закривається вікно
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            username = Username.Text;
            password = Password.Text;
        }

        #region Work this text fields
        /// <summary>
        /// При наведені на текстове поле стирається початкова інформація
        /// </summary>
        private void EnterChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            string text = temp.Text;
            if (text == temp.Name)
                temp.Text = "";
        }

        /// <summary>
        /// При відведені курсору з текстового поля вертається назва поля
        /// </summary>
        private void LeaveChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox temp = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (temp.Text == "")
                temp.Text = temp.Name;
        }
        #endregion
        //Переходимо у форму реєстрації
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Authorization.ActiveForm.Show();
            Sign_in.ActiveForm.Close();
        }
    }
}
