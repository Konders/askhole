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
<<<<<<< HEAD
=======
            //bunifuFlatButton1.Select();
>>>>>>> 09a68d89d619a11c43aa64980fa64cbe4c13cd85
            this.Activate();
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
    }
}
