using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyCuaHangBanSach.DAO
{
    public class DataProvider
    {
        private string serverName = "localhost";
        private string databaseName = "qlchs";
        private string username = "root";
        private string password = "";
        private string port = "2003"; //P.Huy khong ket not dc Port 3306
        private MySqlConnection connect = null;
        private static DataProvider instance;

        public static DataProvider Instance {
            get {
                if (instance == null)
                {
                    instance = new DataProvider();
                }

                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        public DataProvider() {
            this.connect = new MySqlConnection("SERVER=" + this.serverName + ";" +
                    "DATABASE=" + this.databaseName + ";" + "UID=" + this.username + ";" +
                    "PASSWORD=" + this.password + ";" + "PORT=" +this.port + ";");
        }

        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();

            if (connect != null)
            {
                connect.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect);


                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    dataAdapter.Fill(data);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                } finally
                {
                    connect.Close();
                }
            }

            return data;
        }

        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            int data = 0;

            if (connect != null)
            {
                connect.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect);

                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }


                    data = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    connect.Close();
                }
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;

            if (connect != null)
            {
                connect.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    data = cmd.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    connect.Close();
                }
            }

            return data;
        }
    }
}
