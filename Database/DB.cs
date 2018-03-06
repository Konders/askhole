using System;
using System.Data.SqlClient;
using System.Text;
using AskholeLib;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    public class DB
    {
        static public SqlConnection cn;
        static public SqlCommand cmd;
        static public Lib.User user = new Lib.User { username = "test", email =  "test@gmail.com"};
        static public Lib.User reciever = new Lib.User { username = "Ivan" };

        public DB()
        {
            if (Environment.UserName == "olyal")
                cn = new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=Chat;Integrated Security=True");
            else
                cn = new SqlConnection($"Data Source={Environment.MachineName + @"\SQLEXPRESS"};Initial Catalog=Chat;Integrated Security=True");

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
        /// Метод для роботи з бд для повернення результатів
        /// </summary>
        /// <param name="query">запит</param>
        /// <returns>зміну типу sql</returns>
        static private object ReturnMethods(string query)
        {
            try
            {
                object returns = null;
                cn.Open();
                cmd.CommandText = Convert.ToString(query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    returns = reader[0];
                cn.Close();
                return returns;
            }
            catch (SqlException ex)
            {
                cn.Close();
                return null;
            }
        }

        /// <summary>
        /// інформація по користувачах
        /// </summary>
        /// <param name="query">запит</param>
        /// <returns></returns>
        static private List<Lib.User> UsersInfo (string query)
        {
            List<Lib.User> list = new List<Lib.User>();
            try
            {
                object returns = null;
                cn.Open();
                cmd.CommandText = Convert.ToString(query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Lib.User temp = new Lib.User();
                    temp.id = Convert.ToInt32(reader[0]);
                    temp.username = reader[1].ToString();
                    temp.photo = null;//reader[4];
                    temp.birthDate = Convert.ToDateTime(reader[5]);
                    temp.online = Convert.ToBoolean(reader[6]);
                }
                    returns = reader[0];
                cn.Close();
                return list;
            }
            catch (SqlException ex)
            {
                cn.Close();
                return null;
            }
        }

        public static void UsersData(string email)
        {
            int id = IdPicker(email);
            user.username = NamePicker(email);
            user.email = email;          
            user.id = id;
            // функція з бд для фото замість null
            user.photo = null;
            user.birthDate = BirthDatePicker(id);
        }
        static public void DeleteProfile()
        {
            StringBuilder query = new StringBuilder("exec DeleteProfile  '" + user.email);
            DBWork(query.ToString());
        }
        static public void LogOut()
        {
            StringBuilder query = new StringBuilder("exec LogOut  '" + user.email );
            DBWork(query.ToString());
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
            StringBuilder query = new StringBuilder("select dbo.ID('"+email+"')");
            var result = ReturnMethods(query.ToString());
            if (result != null)
                return Convert.ToInt32(result);
            else return -1;
        }

        /// <summary>
        /// отрмання імені користувача по емейлу
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        static public string NamePicker(string email)
        {
            StringBuilder query = new StringBuilder("select dbo.ReturnName('" + email + "')");
            return Convert.ToString(ReturnMethods(query.ToString()));
        }

        /// <summary>
        /// Отримуємо дату народження
        /// </summary>
        static public DateTime BirthDatePicker(int id)
        {
            StringBuilder query = new StringBuilder("select dbo.ReturnBirthDay(" + id + ")");
            var result = ReturnMethods(query.ToString());
            if (result != null)
                return Convert.ToDateTime(result);
            else return DateTime.Now;          
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

        /// <summary>
        /// Зміна імені
        /// </summary>
        /// <param name="name">нове ім'я</param>
        static public void ChangeName(string name)
        {
            StringBuilder query = new StringBuilder("exec ChangeName " + user.id + ",'" + name + "'");
            DBWork(query.ToString());
        }

        /// <summary>
        /// зміна паролю
        /// </summary>
        /// <param name="username">користувач</param>
        /// <param name="email">емейл</param>
        /// <param name="newPassword">новий пароль</param>
        static public bool ResetPassword(string username, string email, string newPassword)
        {
            StringBuilder query = new StringBuilder("exec ToResetPassword '" + username + "', '" +
                                                       email + "', '" + newPassword + "'");
            return DBWork(query.ToString());
        }

        /// <summary>
        /// пошук по імені
        /// </summary>
        /// <param name="name">ім'я</param>
        static public List<Lib.User>  SearchByName(string name)
        {
            StringBuilder query = new StringBuilder("exec SearchByName  '" + name + "'");
            if (query.Length > 0) return UsersInfo(query.ToString());
            else return null;
        }

        /// <summary>
        /// пошук по емейлі
        /// </summary>
        /// <param name="email">емейл</param>
        static public List<Lib.User> SearchByEmail(string email)
        {
            StringBuilder query = new StringBuilder("exec SearchByEmail  '" + email + "'");
            if (query.Length > 0) return UsersInfo(query.ToString());
            else return null;
        }
    }
}