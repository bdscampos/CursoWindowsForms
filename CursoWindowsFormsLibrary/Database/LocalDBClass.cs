using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CursoWindowsFormsLibrary.Database
{
    public class LocalDBClass
    {
        public string StringConnection { get; set; }
        private SqlConnection _connection { get; set; }

        public LocalDBClass()
        {
            try
            {
                StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\CursoWindowsFormsLibrary\\Database\\Fichario.mdf;Integrated Security=True";
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
