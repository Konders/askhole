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
using AskholeLib;
using Bunifu.Framework.UI;

namespace Askhole
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Activate();
            Hamburger.Select();
            var k = DB.cmd;
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
    }
}