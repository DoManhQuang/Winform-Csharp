using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Phần truy vấn logic tới cơ sở dữ liệu
        public DataTable LayDuLieuBangSanPham()
        {
            string cmdText = "select * from tblProduct";
            DataTable dataTable = GetDataTable(cmdText);
            return dataTable;
        }
        // Chìa khóa để mở cơ sở dữ liệu
        private string connection = @"Data Source=DESKTOP-DI6CE7U\SQLEXPRESS;Initial Catalog=Datagridview_iCoding;Integrated Security=True";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connection);
        }
        // Phần truy vấn tương tác với cơ sở dữ liệu
        public DataTable GetDataTable(string cmdText)
        {
            SqlConnection connection = GetConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdText, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSanpham.DataSource = LayDuLieuBangSanPham();
        }
    }
}
