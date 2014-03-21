using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace P3P
{
    public class DatabaseConnector
    {
        private DatabaseConnector() { }

        private static DatabaseConnector instance = new DatabaseConnector();

        public static DatabaseConnector getInstance()
        {
            return instance;
        }


        public void sendPicture(string link, string username)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = @"SET IDENTITY_INSERT Pictures ON";
                    connection.Open();
                    selectCmd.ExecuteNonQuery();
                    selectCmd.CommandText = @" INSERT INTO Messages (link, user) VALUES (@link, @user)";
                    selectCmd.Parameters.AddWithValue("@link", link);
                    selectCmd.Parameters.AddWithValue("@user", username);
                    selectCmd.ExecuteNonQuery();
                    selectCmd.CommandText = @"SET IDENTITY_INSERT Pictures OFF";
                    selectCmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public string getPicture(string username)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = @" SELECT link FROM Pictures WHERE user = @user";
                    selectCmd.Parameters.AddWithValue("@user", username);
                    connection.Open();

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string link = Convert.ToString(reader["link"]);
                            return link;
                        }
                    }
                }
            }
            return null;
        }

        public void setUser(int i, string name, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = @"SET IDENTITY_INSERT Users ON";
                    connection.Open();
                    selectCmd.ExecuteNonQuery();
                    selectCmd.CommandText = @" INSERT INTO Users (UserID, Username, Password) VALUES (@ID, @user, @pass)";
                    selectCmd.Parameters.AddWithValue("@ID", i);
                    selectCmd.Parameters.AddWithValue("@user", name);
                    selectCmd.Parameters.AddWithValue("@pass", password);
                    selectCmd.ExecuteNonQuery();
                    selectCmd.CommandText = @"SET IDENTITY_INSERT Users OFF";
                    selectCmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public User getUserInfo(int i, string name)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = @" SELECT Username, Password FROM Users WHERE UserID = @user";
                    selectCmd.Parameters.AddWithValue("@user", i);
                    connection.Open();

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string user = Convert.ToString(reader["Username"]);
                            string pass = Convert.ToString(reader["Password"]);
                            return new User(user, pass);
                        }
                    }
                }
            }
            return null;
        }

        public List<User> getUsers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = @" SELECT Username, Password FROM Users";
                    connection.Open();
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        List<User> list = new List<User>();
                        while (reader.Read())
                        {
                            string user = Convert.ToString(reader["Username"]);
                            string pass = Convert.ToString(reader["Password"]);
                            list.Add(new User(user, pass));
                        }
                        return list;
                    }
                }
            }
        }

        //EDDY
        public void setalbum(string name)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    connection.Open();
                    selectCmd.CommandText = @" INSERT INTO Albums (name) VALUES (@name)";
                    selectCmd.Parameters.AddWithValue("@name", name);
                    selectCmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }


        public List<string> getalbumnames(int i)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = @" SELECT name FROM Albums WHERE ID >= @ID";
                    selectCmd.Parameters.AddWithValue("@ID", i);
                    connection.Open();

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        List<string> naam = new List<string>();
                        while (reader.Read())
                        {
                            string Name = Convert.ToString(reader["name"]);
                            naam.Add(Name);
                            
                        }
                        
                        return naam;
                    }
                }
            }
        }
        public void Leeg(string naam)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    connection.Open();
                    selectCmd.CommandText = @" DELETE FROM Albums WHERE name=@name";
                    selectCmd.Parameters.AddWithValue("@name", naam);
                    selectCmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void SetFile(string titel, string link, int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["P3P"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand selectCmd = connection.CreateCommand())
                {
                    selectCmd.CommandType = CommandType.Text;
                    connection.Open();
                    selectCmd.CommandText = @" INSERT INTO Pictures (titel, link, AlbumId) VALUES (@titel, @link, @AlbumId)";
                    selectCmd.Parameters.AddWithValue("@titel", titel);
                    selectCmd.Parameters.AddWithValue("@link", link);
                    selectCmd.Parameters.AddWithValue("@AlbumId", id);
                    selectCmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

    }
}