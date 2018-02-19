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
using System.Data.Sql;

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
        List<int> list = new List<int>();
        List<BunifuAnimatorNS.BunifuTransition> transitions;
        Random rand = new Random();

        System.Timers.Timer timer = new System.Timers.Timer();
        SqlConnection cn;
        SqlCommand cmd;
        #endregion

        #region Constructors
        public Sign_in()
        {
            InitializeComponent();
            Enter.Select();


            //this.cn = cn; // з'єднання з ЬД
            //this.cmd = cmd;
        }
        public Sign_in(SqlConnection cn, SqlCommand cmd)
        {
            InitializeComponent();
            Enter.Select(); // керування фокусом
            picture = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3,
                                               pictureBox4, pictureBox5, pictureBox6,
                                               pictureBox7,pictureBox8, pictureBox9 };
            transitions = new List<BunifuAnimatorNS.BunifuTransition>() {
                            bunifuTransition1,  bunifuTransition2};
            RandomPicture();

            timer.Interval = 2000; // таймер для зображень
            timer.Elapsed += ChangePictures;
            timer.Start();

            this.cn = cn; // з'єднання з ЬД
            this.cmd = cmd;
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
            if (!Spelling(username, password)) return;
            
            // перевірка на правильність паролю
            try
            {
                cn.Open();
                StringBuilder str = new StringBuilder("exec SignIn '" + username + "', '" + password + "'");
                cmd.CommandText = Convert.ToString(str);
                //SqlDataReader reader = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Username.Text = Convert.ToString(ex.Message);
            }

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private bool Spelling(string username, string password)
        {
            bool spelling = true;
            if (username.Length < 2)
            {
                ErrorName.ForeColor = Color.Red;
                spelling = false;
            }
            else ErrorName.ForeColor = Color.FromArgb(248, 248, 248);


            if (username.Length < 6)
            {
                ErrorPassword.ForeColor = Color.Red;
                spelling = false;
            }
            else ErrorPassword.ForeColor = Color.FromArgb(248, 248, 248);
            return spelling;
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
        private void SignUp_Click(object sender, EventArgs e)
        {
            //  Authorization.ActiveForm.Show();
            //  Sign_in.ActiveForm.Close();
            this.Hide();
            Authorization authorization = new Authorization(this);
            authorization.Show();
        }
        // Закривається поточне вікно
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // згорнення вікна
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #region Func

        /// <summary>
        /// Загрузка рандомних зображень для початкового вікна
        /// </summary>
        private void RandomPicture()
        {
            for (int i = 0; i < picture.Count; i++) // кількість зображень
            {
                int newRand = NewRand(); // нове число
                picture[i].Image = ImageList.Images[newRand] as Bitmap;
                list.Add(newRand);
            }
        }

        /// <summary>
        /// знаходимо унікальне число для фото якого ще немає в списку
        /// </summary>
        /// <returns></returns>
        private int NewRand()
        {
            while (true)
            {
                bool check = false;
                int key = rand.Next(ImageList.Images.Count);
                foreach (var el in list) // перевірка чи не повторюються зображення
                {
                    if (el == key)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check) // якщо зображення унікальні додається до списку              
                    return key;
            }
        }
        /// <summary>
        /// зміна картинок
        /// </summary>
        private void ChangePictures(Object o, System.Timers.ElapsedEventArgs e)
        {
            int randPic = rand.Next(picture.Count); // рандомне зображення
            var curentPic = picture[randPic];
            int newRand = NewRand(); // нове зображення
            list.Remove(randPic); // редагування списку
            list.Add(newRand);
            int animation = rand.Next(transitions.Count); // рандомна анімація
            transitions[animation].HideSync(curentPic);
            //curentPic.Image = ImageList.Images[newRand] as Bitmap; // міняємо зображення
            transitions[animation].ShowSync(curentPic);

        }
        #endregion

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            Hide();
            ResetPassword rpassword = new ResetPassword(this);
            rpassword.Show();
        }
    }
}
