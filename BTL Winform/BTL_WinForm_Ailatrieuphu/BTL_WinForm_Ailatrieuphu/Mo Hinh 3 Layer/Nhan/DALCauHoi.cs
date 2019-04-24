using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WinForm_Ailatrieuphu
{
   class DALCauHoi
    {
        public SqlConnection getConnect()
        {

            return new SqlConnection(@"Data Source=DESKTOP-DI6CE7U\SQLEXPRESS;Initial Catalog=Ailatrieuphu;Integrated Security=True");


        }
        //lệnh sql trả về 1 bảng
        // datatable và excutenonQuery phải try catch lại 
        public DataTable GetTable(string sql)
        {
            try
            {
                SqlConnection con = getConnect();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public SqlDataReader GetExecuteReader(string cmdText) // gọi hàm này ra thì phải nhớ đóng lại ở tầng được gọi
        {
            SqlConnection connection = getConnect();
            connection.Open();
            SqlCommand command = new SqlCommand(cmdText, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }

    }
}
