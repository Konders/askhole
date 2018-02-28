using Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Askhole
{
    public static class Globals
    {
        public static MainForm mainForm = new MainForm();
    }
    
    class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB db = new DB();
            DB.IdPicker();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(/*new Sign_in(cn, cmd)*/);
            Run();
        }
        public static void Run()
        {
            Application.Run(Globals.mainForm);
        }
    }
}
