using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AskholeLib;

namespace bunitu_install
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Activate();
            Hamburger.Select();
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
            this.Close();
        }
        /// <summary>
        /// //Згортаємо вікно
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
            Control control = (Control)this;
            Lib.Resize(control, startWidth, startHeight);
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

     
    }
}