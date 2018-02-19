using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Resources;
using System.IO;
using Bunifu.Framework.UI;


namespace AskholeLib
{
    public class Lib
    {
        public struct User
        {
            public int id;
            public string username;
            public Bitmap photo;
            public User(int id, string username, Bitmap photo)
            {
                this.id = id;
                this.username = username;
                this.photo = photo;
            }
        }
        /// <summary>
        /// Для керування розміром вікна (розгорнути на весь екран) згорнути
        /// </summary>
        /// <param name="control">активна форма</param>
        /// <param name="startWidth">поточна ширина</param>
        /// <param name="startHeight">поточна висота</param>
        public static void Resize(BunifuImageButton square, Control control, int startWidth, int startHeight)
        {
            
            System.Drawing.Size resolution = Screen.PrimaryScreen.Bounds.Size; // системні значення
            // якщо вікно повністю розгорнуте повертаємо початкові розміри
            if ((control.Width == resolution.Width) && (control.Height == resolution.Height))
            {
                control.Location = new Point((resolution.Width - startWidth) / 2,  // знаходимо центр
                                             (resolution.Height - startHeight) / 2);
                control.Size = new Size(startWidth, startHeight);
              //  square.Image = Properties.Resources.Square;
            
                
            }
            else // якщо вікно повністю маленького розміру
            {
                control.Location = new Point(0, 0);
                control.Size = new Size(resolution.Width, resolution.Height);
                //    square.Image = bunitu_install.Properties.Resources.Square;
            }
        }

        /// <summary>
        /// При редагуванні текстового поля перевірка чи було щось змінено
        /// </summary>
        /// <param name="temp">текстове поле на яке було натиснуто</param>
        public static void LeaveField(Bunifu.Framework.UI.BunifuMaterialTextbox temp)
        {
            if (temp.Text == "")  // перевірка чи щось було змінено
            {
                temp.Text = temp.Name;
                if (temp.Name == "Password") 
                    temp.isPassword = false; // відключення шифрування паролів
            }
            else
            {
                if (temp.Name == "Password") // шифрування пароля
                    temp.isPassword = true;
            }
        }

        /// <summary>
        /// зникнення тексту при наведені на текстове поле
        /// </summary>
        /// <param name="temp">текстове поле на яке було натиснуто</param>
        public static void EnterText(Bunifu.Framework.UI.BunifuMaterialTextbox temp)
        {
            if (temp.Text == temp.Name) // перевірка чи поле поміняло назву
            {
                temp.Text = "";
                if (temp.Name == "Password") // для активізації властивості паролю
                    temp.isPassword = true;
            }
        }
        /// <summary>
        /// Перетворюємо массив байтів в картинку
        /// </summary>
        /// <param name="array">Картинка у вигляді массива байтів</param>
        /// <returns></returns>
        public static Bitmap ByteArrayToImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return new Bitmap(ms);
            }
        }

        /// <summary>
        /// перевірка чи пароль з іменем відповідають умовам
        /// </summary>
        /// <param name="username">ім'я користувача</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        /// <param name="ErName">текст для помилки</param>
        /// <param name="ErPassword">текст для помилки</param>
        /// <returns></returns>
        static public bool Spelling(string username, string password,
                              BunifuCustomLabel ErName, BunifuCustomLabel ErPassword)
        {
            // перевірка чи не початкові дані
            if ((username == "Username") && (password == "Password")) return false;
            if (username.Length < 2) // перевірка імені
            {
                ErName.ForeColor = Color.Red; // попередження
                return false;
            }
            else ErName.ForeColor = Color.FromArgb(248, 248, 248);

            if (password.Length < 6)  // перевірка паролю
            {
                ErPassword.ForeColor = Color.Red; // попередження
                return false;
            }
            else ErPassword.ForeColor = Color.FromArgb(248, 248, 248);
            return true;
        }
    }
}
