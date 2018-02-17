using AskholeLib;
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
        private int startWidth = 753;
        private int startHeight = 379;
        private string password;
        private string username;
        List<PictureBox> picture;
        //   PictureBox[] picture = { pictureBox1, pictureBox2 };
        #endregion

        #region Constructor
        public Sign_in()
        {
            InitializeComponent();
            Enter.Select(); // керування фокусом
            picture = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            for (int i = 0; i < picture.Count; i++)
                picture[i].Image = ImageList.Images[i] as Bitmap; 

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
        #endregion
        //Переходимо у форму реєстрації
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Authorization.ActiveForm.Show();
            Sign_in.ActiveForm.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            Control control = (Control)this;
            Lib.Resize(control, startWidth, startHeight);
            ImageList.ImageSize = new Size(256, 256);
        }
    }
}
