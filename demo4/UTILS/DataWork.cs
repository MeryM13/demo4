using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using demo4.CLASSES;

namespace demo4.UTILS
{
    internal class DataWork
    {
        static string ConnStr = ConnectionString.ConnStr;

        public static string GetHash(string login, string password)
        {
            string salt1 = "^8{-";
            string salt2 = "&>nm";
            string pass = login + salt1 + password + salt2;

            using (var hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(pass)).Select(x => x.ToString("X2")));
            }
        }

        public static User GetUser(string login, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                User user = new User();
                conn.Open();
                string sql = "SELECT  [ID],[Password],[FirstName],[MiddleName],[LastName],[Login],[IsDeleted] " +
                             "FROM [User] " +
                             "WHERE [Login] = @login " +
                             "AND [Password] = @password " +
                             "AND [IsDeleted] = 0";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", GetHash(login, password));

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user.ID = reader.GetInt32(0);
                    user.Password = reader.GetString(1);
                    user.FirstName = reader.GetString(2);
                    user.MiddleName = reader.GetString(3);
                    user.LastName = reader.GetString(4);
                    user.Login = reader.GetString(5);
                    user.IsDeleted = reader.GetBoolean(6);
                    return user;
                }

                throw new Exception("Пользователь не найден. Проверьте правильность данных и повторите попытку входа.");
            }
        }

        public static bool IsExec(User user)
        {
            bool exec = false;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select * from [Executor] where ID = @id";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("id", user.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    exec = true;
                }
            }
            return exec;
        }

        public static bool IsManager(User user)
        {
            bool manager = false;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select * from [Manager] where ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", user.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    manager = true;
                }
            }
            return manager;
        }

        public static string GetExec(int execID)
        {
            string name;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select [User].FirstName, [User].MiddleName, [User].LastName " +
                             "from[User],[Executor] " +
                             "where Executor.ID = [User].ID " +
                             "and Executor.ID = @id ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", execID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name = $"{reader.GetString(0)} {reader.GetString(1)} {reader.GetString(2)}";
                    Console.WriteLine(name);
                    return name;
                }

                throw new Exception("exception");
            }
        }

        public static List<string> GetExecList(int managerID)
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select [User].FirstName, [User].MiddleName, [User].LastName " +
                             "from[User],[Executor] " +
                             "where Executor.ID = [User].ID " +
                             "and Executor.ManagerID = @ManagerID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ManagerID", managerID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add($"{reader.GetString(0)} {reader.GetString(1)} {reader.GetString(2)}");
                }

                return list;
            }
        }

        public static int GetExecID(string name)
        {
            int ID;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select [Executor].ID " +
                             "from Executor, [User] " +
                             "where Executor.ID = [User].ID " +
                             "and [User].FirstName = @first " +
                             "and [User].MiddleName = @middle " +
                             "and [User].LastName = @last";
                SqlCommand cmd = new SqlCommand(sql, conn);
                string[] Name = name.Split(' ');
                cmd.Parameters.AddWithValue("first", Name[0]);
                cmd.Parameters.AddWithValue("middle", Name[1]);
                cmd.Parameters.AddWithValue("last", Name[2]);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID = reader.GetInt32(0);
                    return ID;
                }
            }

            throw new Exception("exception");
        }

        public static DataSet GetExecTasks(User user, string statusFilter)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "  select Task.Title, Task.[Status], [User].FirstName " +
                             "from[User], Executor, Task " +
                             "where Task.ExecutorID = Executor.ID " +
                             "and Executor.ID = [User].ID " +
                             "and Executor.ID = @id";
                if (!String.IsNullOrEmpty(statusFilter))
                    sql += " and Task.Status = @status";
                sql += " order by Task.CreateDateTime desc";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                ada.SelectCommand.Parameters.AddWithValue("id", user.ID);
                if (!String.IsNullOrEmpty(statusFilter))
                    ada.SelectCommand.Parameters.AddWithValue("status", statusFilter);
                ada.Fill(ds);
                return ds;
            }
        }

        public static DataSet GetManagerTasks(User user, string statusFilter, string execFilter)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "  select Task.Title, Task.[Status], [User].FirstName " +
                             "from[User], Executor, Task " +
                             "where Task.ExecutorID = Executor.ID " +
                             "and Executor.ID = [User].ID " +
                             "and Executor.ManagerID = @id";
                if (!String.IsNullOrEmpty(statusFilter))
                    sql += " and Task.Status = @status";
                if (!String.IsNullOrEmpty(execFilter))
                    sql += " and Task.ExecutorId = @execId";
                sql += " order by Task.CreateDateTime desc";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                ada.SelectCommand.Parameters.AddWithValue("id", user.ID);
                if (!String.IsNullOrEmpty(statusFilter))
                    ada.SelectCommand.Parameters.AddWithValue("status", statusFilter);
                if (!String.IsNullOrEmpty(execFilter))
                    ada.SelectCommand.Parameters.AddWithValue("execId", GetExecID(execFilter));
                ada.Fill(ds);
                return ds;
            }
        }

        public static CLASSES.Task GetTask(string title)
        {
            CLASSES.Task task = new CLASSES.Task();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "select * from Task where Task.Title = @title";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("title", title);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    task.ID = reader.GetInt32(0);
                    task.ExecutorID = reader.GetInt32(1);
                    task.Title = reader.GetString(2);
                    try
                    {
                        task.Description = reader.GetString(3);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    task.CreateDateTime = reader.GetDateTime(4);
                    task.Deadline = reader.GetDateTime(5);
                    try
                    {
                        task.Difficulty = reader.GetInt32(6);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    task.Time = reader.GetInt32(7);
                    task.Status = reader.GetString(8);
                    task.WorkType = reader.GetString(9);
                    try
                    {
                        task.CompletedDateTime = reader.GetDateTime(10);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    task.IsDeleted = reader.GetBoolean(11);
                    Console.WriteLine(task.ID);
                    return task;
                }

                throw new Exception("exception");
            }

        }

        public static void DeleteTask(CLASSES.Task task)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "delete from Task where Task.ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", task.ID);
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddTask(CLASSES.Task task)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "insert into Task values" +
                             "(@execId,@title,@desc,@create,@deadline,@difficulty,@time,@status,@work,@complete,@delete)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("execId", task.ExecutorID);
                cmd.Parameters.AddWithValue("title", task.Title);
                cmd.Parameters.AddWithValue("desc", task.Description);
                cmd.Parameters.AddWithValue("create", task.CreateDateTime);
                cmd.Parameters.AddWithValue("deadline", task.Deadline);
                cmd.Parameters.AddWithValue("difficulty", task.Difficulty);
                cmd.Parameters.AddWithValue("time", task.Time);
                cmd.Parameters.AddWithValue("status", task.Status);
                cmd.Parameters.AddWithValue("work", task.WorkType);
                cmd.Parameters.AddWithValue("complete", task.CompletedDateTime);
                cmd.Parameters.AddWithValue("delete", task.IsDeleted);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateTask(CLASSES.Task task)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                string sql = "update Task set " +
                             "ExecutorID = @execId," +
                             "Title = @title," +
                             "Description = @desc," +
                             "CreateDateTime = @create," +
                             "Deadline = @deadline," +
                             "Difficulty = @difficulty," +
                             "Time = @time," +
                             "Status = @status," +
                             "WorkType = @work," +
                             "CompletedDateTime = @complete," +
                             "IsDeleted = @delete " +
                             "where ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", task.ID);
                cmd.Parameters.AddWithValue("execId", task.ExecutorID);
                cmd.Parameters.AddWithValue("title", task.Title);
                cmd.Parameters.AddWithValue("desc", task.Description);
                cmd.Parameters.AddWithValue("create", task.CreateDateTime);
                cmd.Parameters.AddWithValue("deadline", task.Deadline);
                cmd.Parameters.AddWithValue("difficulty", task.Difficulty);
                cmd.Parameters.AddWithValue("time", task.Time);
                cmd.Parameters.AddWithValue("status", task.Status);
                cmd.Parameters.AddWithValue("work", task.WorkType);
                cmd.Parameters.AddWithValue("complete", task.CompletedDateTime);
                cmd.Parameters.AddWithValue("delete", task.IsDeleted);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
