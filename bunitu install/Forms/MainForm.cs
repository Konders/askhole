using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AskholeLib;
using Database;
namespace Askhole
{
    public partial class MainForm : Form
    {       
        static private bool settings = true;
        ContactList cl;
        public MainForm()
        {
            InitializeComponent();
            this.Activate();
            var list = this.Controls[1].Controls[1];
            cl = list as ContactList;
            Hamburger.Select();
            Name.Text = DB.user.username;
                 //     this.Enabled = false;
                 //     Color t = ForeColor;
                 //     this.ForeColor = Color.FromArgb(240, 240, 240, 240);
        }
        #region Variables
        private int startWidth = 753;
        private int startHeight = 570;
        #endregion

        
        /// <summary>
        /// Закриваємо вікно
        /// </summary>
        private void Close_Click(object sender, EventArgs e)
        {           
            Application.Exit();
            //Environment.Exit(0);
        }
        /// <summary>
        /// Згортаємо вікно
        /// </summary>
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Зміна розміру екрану
        /// </summary>
        private void Resize_Click(object sender, EventArgs e)
        {
            var square = Resize;
            Control control = (Control)this;
            if (Lib.Resize(square, control, startWidth, startHeight))
            {
                Resize.Image = Properties.Resources.sq;
                emoji1.Left = this.Size.Width - emoji1.Size.Width *2 + 50;
                emoji1.Top = this.Size.Height - emoji1.Size.Height -150;
            }
            else
            {
                Resize.Image = Properties.Resources.windows;
                emoji1.Left = this.Size.Width - emoji1.Size.Width *2 +50;
                emoji1.Top = this.Size.Height - emoji1.Size.Height -150;
            }
            chat1.threadresize();
        }

        //При поставлені курсору іде підготовка для користувача поля
        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search") // перевірка чи поле поміняло назву
            {
                Search.Text = "";
                closeSearch.Visible = true;
            }
        }
        /// <summary>
        /// Повернення початкового значення для поля пошуку
        /// </summary>
        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text.Length == 0) { Search.Text = "Search";
                closeSearch.Visible = false;
            }
        }

        /// <summary>
        /// вікно з налаштуваннями
        /// </summary>
        private void Hamburger_Click(object sender, EventArgs e)
        {
            if (settings)
            {
                settings1.Visible = true;
                settings = false;
            }
            else
            {
                settings1.Visible = false;
                settings = true;
            }
        }

       public void ChangeName(string name,System.Drawing.Image img)
        {
            pictureBox1.Image = img;
            Name.Text = name;
        }

        private void Hamburger_Click(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// Пошук по списку контактах та пошук нових контактів
        /// </summary>
        private void Search_OnValueChanged(object sender, EventArgs e)
        {

            if (Search.Text.Length > 0)
            {
                cl.ContactsSearch.Clear(); // очищення знайдених контактів
                foreach (var el in cl.Contacts.Values)
                {
                    if (el.username.ToLower().Contains(Search.Text.ToLower())) // якщо є співпадіння
                        cl.AddContactSearch(el.id, el.username); // додаємо новий контакт
                }
                List<Lib.User> list = DB.SearchNewContact(Search.Text);
                if (list.Count > 0) cl.AddContactSearch(list);
                cl.AddButtons(cl.ContactsSearch);
            }
            else // якщо поле пусте показуємо наявні контакти
            { 
                cl.AddButtons(cl.Contacts);
            }

        }

        // закриваємо вікно пошуку
        private void closeSearch_Click(object sender, EventArgs e)
        {
            cl.AddButtons(cl.Contacts); // вертаємо початкові контакти
            Search.Text = ""; // вертаємо початкові значення
            closeSearch.Visible = false;
            Search.Text = "Search";
            Hamburger.Select(); // змінюємо фокус
        }
    }
}