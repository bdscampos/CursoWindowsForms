using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CursoWindowsFormsLibrary.Database
{
    public class SQLServerClass
    {
        public string StringConnection { get; set; }
        private SqlConnection _connection { get; set; }

        public SQLServerClass()
        {
            try
            {
                StringConnection = "Data Source=DESKTOP-1KAAFIK;Initial Catalog=ByteBank;Integrated Security=True";
                //StringConnection = ConfigurationManager.ConnectionStrings["Fichario"].ConnectionString;
                _connection = new SqlConnection(StringConnection);
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string SQLCommand(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, _connection);
                command.CommandTimeout = 0;
                SqlDataReader reader = command.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public DataTable SQLQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(sql, _connection);
                command.CommandTimeout = 0;
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

    }
}
