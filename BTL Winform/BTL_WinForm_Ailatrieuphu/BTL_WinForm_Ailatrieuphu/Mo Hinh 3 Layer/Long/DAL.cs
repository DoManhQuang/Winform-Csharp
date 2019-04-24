using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyVien
{
    class DAL
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-DI6CE7U\SQLEXPRESS;Initial Catalog=Ailatrieuphu;Integrated Security=True");
        }
        public DataTable GetTable(String sql)
        {
            try
            {
                SqlConnection conn = getConnect();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi! \n" + ex.ToString());
                return null;
            }
        }
        public void ExcuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public SqlDataReader GetExecuteReader(string cmdText)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand command = new SqlCommand(cmdText, conn);
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }

    }
}
