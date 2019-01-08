using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    public class SQLHelper
    {
        public SqlConnection Conn { get; set; }
        public string connectionString { get; set; }
        public SqlCommand command { get; set; }

        public SQLHelper()
        {
            connectionString = @"Data Source = WISSEN\SQLEXPRESS; Database = DuesManagement; Trusted_connection = true; User ID = Section1";
            Conn = new SqlConnection(connectionString);
        }

        public void ExecuteCommand(string query)
        {
            command = new SqlCommand(query, Conn);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public DataTable GetData(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public void ExecuteProcedure(string procName, params SqlParameter[] p)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Connection = Conn;
            command.Parameters.AddRange(p);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
