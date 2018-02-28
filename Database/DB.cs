using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AskholeLib;

namespace Database
{

    public class DB
    {
        static public SqlConnection cn;
        static public SqlCommand cmd;
        static public Lib.User user = new Lib.User { username = "user" };
        static public Lib.User reciever = new Lib.User { username = "Ivan" };
        // static public string UserName { get; set; } // поточний користувач
        //  static public string RecieverName { get; set; } // отримувач

        public DB()
        {
            if (Environment.UserName == "olyal")
                cn = new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=Chat;Integrated Security=True");
            else
                cn = new SqlConnection($"Data Source={Environment.MachineName + @"\SQLEXPRESS"};Initial Catalog=Chat;Integrated Security=True");

            cmd = new SqlCommand { Connection = cn };
        }

        /// <summary>
        /// Вхід в систему
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        static public bool SignIn(string email, string password)
        {
            try
            {
                cn.Open(); // запит до бд
                StringBuilder str = new StringBuilder("exec SignIn '" + email + "', '" +
                                                        password + "'");
                cmd.CommandText = Convert.ToString(str);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                cn.Close();
                return false;
            }
        }

        /// <summary>
        /// Добавлення текстового повідомлення до БД
        /// </summary>
        /// <param name="text">текст повідомлення</param>
        /// <param name="time">час</param>
        static public void AddMessageText(string text, DateTime time)
        {
            try
            {
                cn.Open(); // запит до бд
                StringBuilder str = new StringBuilder("exec AddingMessage  '" + user.username + "', '" +
                                       reciever.username + "', '" + text + "', '" + time + "'");
                cmd.CommandText = Convert.ToString(str);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (SqlException ex)
            {
                cn.Close();
            }
        }

        /// <summary>
        /// Створпення нового користувача
        /// </summary>
        /// <param name="userName">ім'я</param>
        /// <param name="password">пароль</param>
        /// <param name="email">емейл</param>
        /// <param name="birthDay">дата народження</param>
        /// <returns></returns>
        static public bool NewUser(string userName, string password, string email, DateTime birthDay)
        {
            try
            {
                cn.Open();
                StringBuilder comand = new StringBuilder("exec AddUser '" + userName + "', '" +
                              password + "', '" + email + "', '" + birthDay + "'");
                cmd.CommandText = Convert.ToString(comand);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                cn.Close();
                return false;
            }
        }

        /// <summary>
        /// Отримання id користувача
        /// </summary>
        /// <param name="email">пошта</param>
        /// <returns></returns>
        static public int IdPicker(string email)
        {
            try
            {
                cn.Open();
                StringBuilder comand = new StringBuilder("exec ID_user '"+email+"'");
                cmd.CommandText = Convert.ToString(comand);
                //SqlParameter retValue = cmd.Parameters.Add("@id", SqlDbType.Int);
                //retValue.Direction = ParameterDirection.ReturnValue;
                //int tmp =  
                    cmd.ExecuteNonQuery();
                cn.Close();
                return -1;
            }
            catch (SqlException ex)
            {
                int tmp =Convert.ToInt32(ex.Message);
                cn.Close();
                return tmp;
            }
        }

        /// <summary>
        /// отрмання імені користувача по емейлу
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        static public string NamePicker(string email)
        {
            try
            {
                cn.Open();
                StringBuilder comand = new StringBuilder("exec ID_username '" + email + "'");
                cmd.CommandText = Convert.ToString(comand);
                cmd.ExecuteNonQuery();
                cn.Close();
                return null;
            }
            catch (SqlException ex)
            {
                string tmp = ex.Message;
                cn.Close();
                return tmp;
            }
        }
    }
}