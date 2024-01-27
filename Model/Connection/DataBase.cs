using System;
using System.Data.SqlClient;
using System.Data;

namespace Model.Connection
{
    public sealed class DataBase
    {
        private readonly static SqlConnection conn = new SqlConnection();

        public static SqlConnection Connection
        {
            get
            {
                if (conn.State == ConnectionState.Closed)
                    OpenConnection();

                return conn;
            }
        }

        public static void OpenConnection()
        {
            try
            {
                conn.ConnectionString = Data.Get("ConnectionString");
                conn.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error al abrir la conexión.");
            }
        }

        public static void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error al cerrar la conexión.");
            }
        }

        private DataBase() { }
    }
}
