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
        List<int> list = new List<int>();
        List<BunifuAnimatorNS.BunifuTransition> transitions;
        Random rand = new Random();

        System.Timers.Timer timer = new System.Timers.Timer();
        #endregion

        #region Constructor
        public Sign_in()
        {        
            InitializeComponent();
            Enter.Select(); // керування фокусом
            picture = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3,
                                               pictureBox4, pictureBox5, pictureBox6,
                                               pictureBox7,pictureBox8, pictureBox9 };
            transitions = new List<BunifuAnimatorNS.BunifuTransition>() {
                            bunifuTransition1,  bunifuTransition2, bunifuTransition3,
                            bunifuTransition4, bunifuTransition5};
            RandomPicture();
            timer.Interval = 2000;
            timer.Elapsed += ChangePictures;
            timer.Start();
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

        #region Func

        /// <summary>
        /// Загрузка рандомних зображень для початкового вікна
        /// </summary>
        private void RandomPicture()
        {
            for (int i = 0; i < picture.Count; i++) // кількість зображень
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
                    {
                        list.Add(key);
                        picture[i].Image = ImageList.Images[key] as Bitmap;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// зміна картинок
        /// </summary>
        private void ChangePictures(Object o, System.Timers.ElapsedEventArgs e)
        {
            int randPic = rand.Next(picture.Count);
            var curentPic = picture[randPic];
            int animation = rand.Next(transitions.Count);
            //  if (curentPic.Visible == false)
            transitions[animation].HideSync(curentPic);
            transitions[animation].ShowSync(curentPic);
        //    else
          //      transitions[animation].HideSync(curentPic);
        }
        #endregion
    }
}
