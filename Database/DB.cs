using System;
using System.Data.SqlClient;
using System.Text;
using AskholeLib;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace Database
{
    public enum Status
    {
        Loading,
        Finished_True,
        Finished_False
    }
    public class QueryStatus
    {
        public string query;
        public object container;
        public Status status;
        public QueryStatus()
        {
            query = "";
            container = null;
            status = Status.Loading;
        }
        public QueryStatus(string query)
        {
            this.query = query;
            container = null;
            status = Status.Loading;
        }
        public bool BoolStatus()
        {
            switch(status)
            {
                case Status.Finished_True: return true;
                    break;
                case Status.Finished_False: return false;
                    break;
                default: return false;
            }
        }
    }
    public class ConnectionCMD
    {
        public SqlConnection cn ;
        public SqlCommand cmd;
        public ConnectionCMD()
        {
            cn = DB.ReadyConnection();
            cmd = new SqlCommand { Connection = cn };
        }

    }
    public class DB
    {
        //static public Thread DatabaseThread;
        //static public SqlConnection cn;
        //static public SqlCommand cmd;
        static public Lib.User user = new Lib.User { username = "test", email =  "test@gmail.com"};
        static public Lib.User reciever = new Lib.User { username = "Ivan" };
        
        static public SqlConnection ReadyConnection()
        {
            if (Environment.UserName == "olyal")
                return  new SqlConnection($"Data Source={Environment.MachineName};Initial Catalog=Chat;Integrated Security=True");
            else
                return new SqlConnection($"Data Source={Environment.MachineName + @"\SQLEXPRESS"};Initial Catalog=Chat;Integrated Security=True");
        }
        public DB()
        {
        }


        static private void Execute(object x)
        {
            ConnectionCMD temp = x as ConnectionCMD;
            try
            {
                temp.cn.Open();
                temp.cmd.ExecuteNonQuery();
                temp.cn.Close();
                
            }
            catch (SqlException ex)
            {
                temp.cn.Close();
                throw;
            }
        }
        /// <summary>
        /// Активація та виконання запитів в базі даних
        /// </summary>
        /// <param name="str">запит</param>
        /// <returns></returns>
        static private void DBWork(object qs)
        {
            ConnectionCMD cn = new ConnectionCMD();
            try
            {
                cn.cn.Open(); // запит до бд
                cn.cmd.CommandText = (qs as QueryStatus).query;
                cn.cmd.ExecuteNonQuery();
                cn.cn.Close();
                (qs as QueryStatus).status = Status.Finished_True;
            }
            catch (Exception e)
            {
                cn.cn.Close();
                (qs as QueryStatus).status = Status.Finished_False;
            }
        }

        /// <summary>
        /// Метод для роботи з бд для повернення результатів
        /// </summary>
        /// <param name="query">запит</param>
        /// <returns>зміну типу sql</returns>
        static private void ReturnMethods(object qs)
        {
            ConnectionCMD cn = new ConnectionCMD();
            try
            {
                
                cn.cn.Open();
                cn.cmd.CommandText = (qs as QueryStatus).query;
                SqlDataReader reader = cn.cmd.ExecuteReader();
                while (reader.Read())
                    (qs as QueryStatus).container = reader[0];
                cn.cn.Close();
                (qs as QueryStatus).status = Status.Finished_True;
            }
            catch (SqlException ex)
            {
                cn.cn.Close();
                (qs as QueryStatus).container = null;
                (qs as QueryStatus).status = Status.Finished_False;;
            }
        }

        /// <summary>
        /// інформація по користувачах
        /// </summary>
        /// <param name="query">запит</param>
        /// <returns></returns>
        static private/* List<Lib.User>*/ void UsersInfo (object qs)
        {
            List<Lib.User> list = new List<Lib.User>();
            ConnectionCMD cn = new ConnectionCMD();
            try
            {
                cn.cn.Open();
                cn.cmd.CommandText = (qs as QueryStatus).query;
                SqlDataReader reader = cn.cmd.ExecuteReader();
                while (reader.Read())
                {
                    Lib.User temp = new Lib.User();
                    temp.id = Convert.ToInt32(reader[0]);
                    temp.username = reader[1].ToString();
                    temp.photo = null;//reader[4];
                    temp.birthDate = Convert.ToDateTime(reader[5]);
                    temp.online = Convert.ToBoolean(reader[6]);
                }
                    (qs as QueryStatus).container = reader[0];
                cn.cn.Close();
                (qs as QueryStatus).status = Status.Finished_True;
                //return list;
            }
            catch (SqlException ex)
            {
                cn.cn.Close();
                (qs as QueryStatus).container = null;
                (qs as QueryStatus).status = Status.Finished_False;
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
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(DBWork));
            StringBuilder query = new StringBuilder("exec DeleteProfile  '" + user.email);
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            /*while (qs.status == Status.Loading)
                //loading
                continue;*/
        }
        static public void LogOut()
        {
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(DBWork));
            StringBuilder query = new StringBuilder("exec LogOut  '" + user.email );
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
        }
        /// <summary>
        /// Вхід в систему
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        static public bool SignIn(string email, string password)
        {
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(DBWork));
            StringBuilder query = new StringBuilder("exec SignIn '" + email + "', '" +
                                                       password + "'");
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            return qs.BoolStatus();
        }

        /// <summary>
        /// Добавлення текстового повідомлення до БД
        /// </summary>
        /// <param name="text">текст повідомлення</param>
        /// <param name="time">час</param>
        static public void AddMessageText(string text, DateTime time)
        {
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(DBWork));
            StringBuilder query = new StringBuilder("exec AddingMessage  '" + user.username + "', '" +
                                      reciever.username + "', '" + text + "', '" + time + "'");
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
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
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(DBWork));
            StringBuilder query = new StringBuilder("exec AddUser '" + userName + "', '" +
                             password + "', '" + email + "', '" + birthDay + "'");
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            return qs.BoolStatus();
        }

        /// <summary>
        /// Отримання id користувача
        /// </summary>
        /// <param name="email">пошта</param>
        /// <returns></returns>
        static public int IdPicker(string email)
        {
            StringBuilder query = new StringBuilder("select dbo.ID('"+email+"')");
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(ReturnMethods));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            if (qs.container != null)
                return Convert.ToInt32(qs.container);
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
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(ReturnMethods));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            return Convert.ToString(qs.container.ToString());
        }

        /// <summary>
        /// Отримуємо дату народження
        /// </summary>
        static public DateTime BirthDatePicker(int id)
        {
            StringBuilder query = new StringBuilder("select dbo.ReturnBirthDay(" + id + ")");
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(ReturnMethods));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            if (qs.container != null)
                return Convert.ToDateTime(qs.container);
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
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(DBWork));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading bar
                continue;
            return qs.BoolStatus();
        }

        /// <summary>
        /// пошук по імені
        /// </summary>
        /// <param name="name">ім'я</param>
        static public List<Lib.User>  SearchByName(string name)
        {
            StringBuilder query = new StringBuilder("exec SearchByName  '" + name + "'");
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(UsersInfo));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            if (query.Length > 0) return qs.container as List<Lib.User>;
            else return null;
        }

        /// <summary>
        /// пошук по емейлі
        /// </summary>
        /// <param name="email">емейл</param>
        static public List<Lib.User> SearchByEmail(string email)
        {
            StringBuilder query = new StringBuilder("exec SearchByEmail  '" + email + "'");
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(UsersInfo));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            if (query.Length > 0) return qs.container as List<Lib.User>;
            else return null;
        }

        static public List<Lib.User> SearchNewContact(string findString)
        {
            bool emailAdress = false;
            StringBuilder query;
            if (new EmailAddressAttribute().IsValid(findString))
                emailAdress = true;
            if (emailAdress) query = new StringBuilder("exec SearchByEmail  '" + findString + "'");
            else query = new StringBuilder("exec SearchNewContact '" + findString + "'");
            Thread DatabaseThread = new Thread(new ParameterizedThreadStart(UsersInfo));
            QueryStatus qs = new QueryStatus(query.ToString());
            DatabaseThread.Start(qs);
            while (qs.status == Status.Loading)
                //loading
                continue;
            if (query.Length > 0) return qs.container as List<Lib.User>;
            else return null;
        }
    }
}