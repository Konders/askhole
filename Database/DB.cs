using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
<<<<<<< HEAD
    public struct Users
    {
        public string Name { get; set; }
        public int Id { get; set; }
=======
    public struct User
    {
        public string name;
        public int id;
>>>>>>> 1eab9d5c9ed9ac2d7dce71e185034d0e1adef032
    }
    public class DB
    {
        static public SqlConnection cn;
        static public SqlCommand cmd;
<<<<<<< HEAD
        static public Users user = new Users { Name = "user" };
        static public Users reciever = new Users { Name = "Ivan" };
        // static public string UserName { get; set; } // поточний користувач
        //  static public string RecieverName { get; set; } // отримувач
=======
        static public User user = new User(); // поточний користувач
        static public User Reciever = new User(); // отримувач
>>>>>>> 1eab9d5c9ed9ac2d7dce71e185034d0e1adef032
        public DB()
        {
            if (Environment.UserName == "olyal")
                cn = new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=Chat;Integrated Security=True");
            else
                cn = new SqlConnection($"Data Source={Environment.MachineName + @"\SQLEXPRESS"};Initial Catalog=Chat;Integrated Security=True");

            cmd = new SqlCommand { Connection = cn };
<<<<<<< HEAD
=======
            user.name = "user";
            Reciever.name = "Ivan";
>>>>>>> 1eab9d5c9ed9ac2d7dce71e185034d0e1adef032
        }

        /// <summary>
        /// Вхід в систему
        /// </summary>
        /// <param name="username">ім'я користувача</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        static public bool SingIn(string username, string password)
        {
            try
            {
                cn.Open(); // запит до бд
                StringBuilder str = new StringBuilder("exec SignIn '" + username + "', '" +
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
<<<<<<< HEAD
                StringBuilder str = new StringBuilder("exec AddingMessage  '" + user.Name + "', '" +
                                       reciever.Name + "', '" + text + "', '" + time + "'");
=======
                StringBuilder str = new StringBuilder("exec AddingMessage  '" + user.name + "', '" +
                                       Reciever.name + "', '" + text + "', '" + time + "'");
>>>>>>> 1eab9d5c9ed9ac2d7dce71e185034d0e1adef032
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
    }
}