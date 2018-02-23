using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Askhole
{
    class DB
    {
         static public SqlConnection cn;
        static public  SqlCommand cmd;
        static public string UserName { get; set; }
        static public string RecieverName { get; set; }
        public DB()
        {
            if (Environment.UserName == "olyal")
                cn = new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=Chat;Integrated Security=True");
            else
                cn = new SqlConnection($"Data Source={Environment.MachineName + @"\SQLEXPRESS"};Initial Catalog=Chat;Integrated Security=True");

            cmd = new SqlCommand {Connection = cn};
        }
    }
    static class Program
    {      
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB db = new DB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*new Sign_in(cn, cmd)*/new MainForm());
        }
    }
}
