using AskholeLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
namespace Askhole
{

    public partial class Sign_in : Form
    {
        #region Variables
        private string password;
        private string email;
        List<PictureBox> picture;
        List<int> list = new List<int>();
        List<BunifuAnimatorNS.BunifuTransition> transitions;
        Random rand = new Random();

        System.Timers.Timer timer = new System.Timers.Timer();
        #endregion

        #region Constructors
     
        public Sign_in()
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
            //timer.Start();
        }
        #endregion

        // закривається вікно
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            email = Email.Text;
            password = Password.Text;
            // якщо паролі не відповідають вимогам нічого не міняється
            if (!Lib.Spelling(email, password, ErrorName, ErrorPassword)) return;
            if (DB.SignIn(email, password))
            {
                Hide();
                //MainForm mainForm = new MainForm(); // форма з повідомленнями               
                Globals.mainForm = new MainForm();
                Globals.mainForm.Show();
                DB.UsersData(email);
              
                //timer.Stop();
                Error.Hide(); // вертаємо колір помилки
            }
            else Error.Show(); // вертаємо колір помилки          
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
            Hide();
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
