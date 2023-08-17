using System;
using System.Collections.Generic;
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
            set { DataProvider.instance = value; }
        }

        public DataProvider() {
            connect = new MySqlConnection("SERVER=" + this.serverName + ";" +
                    "DATABASE=" + this.databaseName + ";" + "UID=" + this.username + ";" +
                    "PASSWORD=" + this.password + ";");
        }

        public DataProvider(string serverName, string databaseName, string username, string password)
        {
            connect = new MySqlConnection("SERVER=" + serverName + ";" +
                "DATABASE=" + databaseName + ";" + "UID=" + username + ";" +
                "PASSWORD=" + password + ";");
        }
    }
}
