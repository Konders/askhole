using System;
using System.Windows.Forms;
using AskholeLib;
using Database;
namespace Askhole
{
    public partial class MainForm : Form
    {       
        static private bool settings = true;
        public MainForm()
        {
            InitializeComponent();
            this.Activate();
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
            Resize.Image = Properties.Resources.sq;
            else
                Resize.Image = Properties.Resources.windows;
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search") // перевірка чи поле поміняло назву
                Search.Text = "";
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text.Length == 0) Search.Text = "Search";
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

    }
}