using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer
{
    class BLLayer02
    {
        DALayer01 Layer01 = new DALayer01();
        public void CloseConnection()
        {
            SqlConnection connection = Layer01.GetSqlConnection();
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public DataTable LayThongTinNguoiChuoi(string Taikhoan)
        {
            string cmdText = "select * from ThongTinNguoiDung('" + Taikhoan + "')";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public string XuLyMaTK(string matk)
        {
            matk = matk.Remove(0, 2);
            int matkNew = int.Parse(matk) + 1;
            matk = "TK00" + matkNew;
            return matk;
        }
        public string GetMaTKNew()
        {
            string cmdText = "select dbo.MaxMaTKTheoChucNang('1')";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return XuLyMaTK(dataReader[0].ToString());
            }
            return null;
        }
        public bool Kiemtratentaikhoan(string taikhoan)
        {
            string cmdText = "select dbo.DemSoLuongTaiKhoan('" + taikhoan + "')";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read() && int.Parse(dataReader[0].ToString()) == 0)
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
        public bool DangKyTaiKhoanNguoiChoi(string matk ,string taikhoan , string matkhau , string hoten , int gioitinh , 
            string sdt , string email , int trangthai , int Chucnang)
        {
            try
            {
                CloseConnection();
                string cmdText = "EXEC TaoTaiKhoanMoi '" + matk + "','" + taikhoan + "','" + matkhau + "'," +
                    "N'" + hoten + "','" + gioitinh + "','" + sdt + "','" + email + "','" + trangthai + "'" + ", '" + Chucnang + "'";
                Layer01.ExecuteNonQuery(cmdText);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool Kiemtradangnhap(string taikhoan, string matkhau)
        {
            string cmdText = "select dbo.DemSoLuongMaTK('" + taikhoan + "','" + matkhau + "')";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read() && int.Parse(dataReader[0].ToString()) == 1)
            {
                CloseConnection();
                return true;
            }
            CloseConnection();    
            return false;
        }

        public bool CapNhapThongTinNguoiChoi(string matk, string taikhoan, string matkhau, string hoten, int gioitinh,
            string sdt, string email)
        {
            try
            {
                string cmdText = "EXEC CapNhapThongTin '" + matk + "' , '" + taikhoan + "' , '" + matkhau + "'" +
                    " , N'" + hoten + "' , '" + gioitinh + "' , '" + sdt + "' , '" + email + "'";
                Layer01.ExecuteNonQuery(cmdText);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public string LayMaTaiKhoan(string taikhoan)
        {
            string cmdText = "select dbo.LayMaTaiKhoan('" + taikhoan + "') ";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return dataReader[0].ToString();// index = 0 chỉ thứ tự được select ra ở đây thứ tự 0 là count(ma)
            }
            return null; // chưa có mã nào trong bảng sản phẩm.
        }
        public int ChucNangNguoiDung(string taikhoan , string matkhau)
        {
            string cmdText = "select dbo.ChucNangNguoiDung('" + taikhoan + "','" + matkhau + "')";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return int.Parse(dataReader[0].ToString());// index = 0 chỉ thứ tự được select ra ở đây thứ tự 0 là count(ma)
            }
            return 0;
        }
        public string LayMaKyThuatVien(string taikhoan)
        {
            string cmdText = "select dbo.LayMaKTV('" + taikhoan + "')";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if(dataReader.Read())
            {
                return dataReader[0].ToString().Trim();
            }
            return null;
        }
        public string LayMaQuanLyVien(string taikhoan)
        {
            string cmdText = "select dbo.LayMaQLV('" + taikhoan + "')";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return dataReader[0].ToString().Trim();
            }
            return null;
        }
    }
}
