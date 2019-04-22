using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer
{
    class DALayer01
    {
        private String connectionString = @"Data Source=DESKTOP-DI6CE7U\SQLEXPRESS;Initial Catalog=Ailatrieuphu;Integrated Security=True";
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
        public DataTable GetDataTable(string cmdText)
        {
            SqlConnection connection = GetSqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdText, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataSet GetDataSet(string cmdText)
        {
            SqlConnection connection = GetSqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdText, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
        public SqlDataReader GetExecuteReader(string cmdText) // gọi hàm này ra thì phải nhớ đóng lại ở tầng được gọi
        {
            SqlConnection connection = GetSqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(cmdText, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }
        public void ExecuteNonQuery(string cmdText)
        {
            SqlConnection connection = GetSqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
