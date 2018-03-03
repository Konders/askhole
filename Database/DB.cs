using System;
using System.Data.SqlClient;
using System.Text;
using AskholeLib;

namespace Database
{
    public class DB
    {
        static public SqlConnection cn;
        static public SqlCommand cmd;
        static public Lib.User user = new Lib.User { username = "user" };
        static public Lib.User reciever = new Lib.User { username = "Ivan" };

        public DB()
        {
            if (Environment.UserName == "olyal")
                cn = new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=Chat;Integrated Security=True");
            else
                cn = new SqlConnection($"Data Source={Environment.MachineName + @"SQLEXPRESS"};Initial Catalog=Chat;Integrated Security=True");

            cmd = new SqlCommand { Connection = cn };
        }

        /// <summary>
        /// Активація та виконання запитів в базі даних
        /// </summary>
        /// <param name="str">запит</param>
        /// <returns></returns>
        static private bool DBWork(string query)
        {
            try
            {
                cn.Open(); // запит до бд
                cmd.CommandText = Convert.ToString(query);
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
        /// Вхід в систему
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        static public bool SignIn(string email, string password)
        {
            StringBuilder query = new StringBuilder("exec SignIn '" + email + "', '" +
                                                       password + "'");
            return DBWork(query.ToString());
        }

        /// <summary>
        /// Добавлення текстового повідомлення до БД
        /// </summary>
        /// <param name="text">текст повідомлення</param>
        /// <param name="time">час</param>
        static public void AddMessageText(string text, DateTime time)
        {
            StringBuilder query = new StringBuilder("exec AddingMessage  '" + user.username + "', '" +
                                      reciever.username + "', '" + text + "', '" + time + "'");
            DBWork(query.ToString());
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
            StringBuilder query = new StringBuilder("exec AddUser '" + userName + "', '" +
                             password + "', '" + email + "', '" + birthDay + "'");
            return DBWork(query.ToString());
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
                StringBuilder comand = new StringBuilder("exec ID_user '" + email + "'");
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
                int tmp = Convert.ToInt32(ex.Message);
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

        /// <summary>
        /// Отримуємо дату народження
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public DateTime BirthDatePicker(int id)
        {
            return DateTime.Now;
            try
            {
                cn.Open();
                StringBuilder comand = new StringBuilder("exec ID_username '" + id + "'");
                cmd.CommandText = Convert.ToString(comand);
                cmd.ExecuteNonQuery();
                cn.Close();
                return DateTime.Now;
            }
            catch (SqlException ex)
            {
                //  DateTime tmp = Convert.DateTime( ex.Message);
                cn.Close();
                //   return tmp;
            }
        }

        /// <summary>
        /// змін дати народження
        /// </summary>
        /// <param name="date"></param>
        static public void ChangeBirthDay(DateTime date)
        {
            StringBuilder query = new StringBuilder("exec ChangeBirthDate '" + user.id + "','" + date + "'");
            DBWork(query.ToString());
        }

        static public void ChangeName(string name)
        {
            StringBuilder query = new StringBuilder("exec ChangeName " + user.id + ",'" + name + "'");
            DBWork(query.ToString());
        }

        static public bool ResetPassword(string username, string email, string newPassword)
        {
            StringBuilder query = new StringBuilder("exec ToResetPassword '" + username + "', '" +
                                                       email + "', '" + newPassword + "'");
            return DBWork(query.ToString());
        }
    }
}