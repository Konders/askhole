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
    public partial class StartWindow : Form
    {
        #region Variables
        private int startWidth = 825;
        private int startHeight = 447;
        #endregion

        public StartWindow()
        {
            InitializeComponent();
        }

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
            Size resolution = Screen.PrimaryScreen.Bounds.Size; // системні значення

            Control control = (Control)this;
            // якщо вікно повністю розгорнуте повертаємо початкові розміри
            if ((control.Width == resolution.Width) && (control.Height == resolution.Height))
            {
                control.Location = new Point((resolution.Width- startWidth)/2,  // знаходимо центр
                                             (resolution.Height- startHeight)/2); 
                control.Size = new Size(startWidth, startHeight);
            }
            else // якщо вікно повністю маленького розміру
            {
                control.Location = new Point(0, 0);
                control.Size = new Size(resolution.Width, resolution.Height);
            }
        }
    }
}
