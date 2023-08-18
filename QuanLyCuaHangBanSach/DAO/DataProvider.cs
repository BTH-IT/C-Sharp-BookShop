using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLyCuaHangBanSach.DAO
{
    public class DataProvider
    {
        private string serverName = "localhost";
        private string databaseName = "qlchs";
        private string username = "root";
        private string password = "hung";
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
                    "PASSWORD=" + this.password + ";");
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            if (connect != null)
            {
                connect.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect);
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

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
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
                        foreach (SqlParameter param in parameters)
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
