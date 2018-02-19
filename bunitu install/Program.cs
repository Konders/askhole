using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bunitu_install
{
    static class Program
    {
        static SqlConnection cn;
        static SqlCommand cmd;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            cn = new SqlConnection("Data Source=DESKTOP-75CHCH4;Initial Catalog=Chat;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = cn;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sign_in(cn, cmd));
        }
    }
}
