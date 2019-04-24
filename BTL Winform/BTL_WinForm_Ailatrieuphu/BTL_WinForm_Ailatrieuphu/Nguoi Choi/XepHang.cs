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

namespace LichSuChoi
{
    public partial class XepHangNguoiChoi : Form
    {
        public XepHangNguoiChoi()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void LichSuChoi_Load(object sender, EventArgs e)
        {
            String connString = @"Data Source=DESKTOP-DI6CE7U\SQLEXPRESS;Initial Catalog=Ailatrieuphu;Integrated Security=True";
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            String cmdText = "select top 10 TenNguoiDung,KQtotnhat, Tienthuong from tblTaikhoan inner join tblNguoiChoi on tblNguoiChoi.MaTK = tblTaikhoan.MaTK order by KQtotnhat DESC";
            SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLichSuChoi.DataSource = dt;

            //Tự động đánh STT
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvLichSuChoi.Rows[i].Cells[0].Value = (i + 1);
            }
            dgvLichSuChoi.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            dgvLichSuChoi.Rows[1].DefaultCellStyle.BackColor = Color.Silver;
            dgvLichSuChoi.Rows[2].DefaultCellStyle.BackColor = Color.YellowGreen;

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
