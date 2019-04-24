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
    class BLL
    {
        DAL myDAL = new DAL();
        public DataTable ShowKyThuatVien()
        {
            String sql = "select Taikhoan, Matkhau, TenNguoiDung,GioiTinh,Sodienthoai,Email,Trangthai,Vaitro from tblTaikhoan inner join tblKyThuatVien on tblKyThuatVien.MaTK = tblTaikhoan.MaTK";
            
            DataTable dt = new DataTable();
            dt = myDAL.GetTable(sql);
            return dt;
        }

        public void InsertTaiKhoan(String maTK, string taiKhoan, String matKhau, String tenND , Boolean gt,String soDT, String email, Boolean trangThai, int chucNang)
        {
            String sqlTaiKhoan = "insert into tblTaikhoan values (N'" + maTK + "',N'" + taiKhoan + "','" + matKhau + "',N'" + tenND + "','" + gt + "' , '" + soDT + "',N'" + email + "','" + trangThai + "','"+chucNang+"')";
            myDAL.ExcuteNonQuery(sqlTaiKhoan);
        }
        public void InsertKyThuatVien(String maKTV, String maQLV,String maTK, String vaiTro)
        {
            String sql = "insert into tblKyThuatVien values ('" + maKTV + "','" + maQLV + "','" + maTK + "','" + vaiTro + "')";
            myDAL.ExcuteNonQuery(sql);
        }

        public void UpdateTaiKhoan(string taiKhoan, String matKhau, String tenND, Boolean gt, String soDT, String email, Boolean trangThai, int chucNang)
        {
            String sql = "update tblTaikhoan set Matkhau  = N'" + matKhau + "',TenNguoiDung = N'" + tenND + "',GioiTinh = '" + gt + "' ,Sodienthoai = '" + soDT + "',Email = N'" + email + "',TrangThai = '" + trangThai + "',ChucNang = '"+ chucNang + "' where Taikhoan = N'" + taiKhoan + "' ";
            myDAL.ExcuteNonQuery(sql);
        }
        public void UpdateKyThuatVien(String tenTK, String vaiTro)
        {
            String maTK = GetLayMaTK(tenTK);
            String sql = "update tblKyThuatVien set Vaitro  = '" + vaiTro + "' where MaTK = '"+maTK+"'";
            myDAL.ExcuteNonQuery(sql);
        }
       
        public void DeleteTaiKhoan(String tenTK)
        {
            string sql = "delete tblTaiKhoan where Taikhoan = N'" + tenTK + "'";
            myDAL.ExcuteNonQuery(sql);
        }

        public void DeleteKyThuatVien(String maKTV)
        {
            string sql = "delete tblKyThuatVien where MaKTV = N'" + maKTV + "'";
            myDAL.ExcuteNonQuery(sql);
        }

        public DataTable timKiemKTV(String dk)
        {
            String sql = "select * from tblQuanlyvien where MaQLV like N'%" + dk + "%' or TenQL like N'"+ dk +"' " ;
            DataTable dt = new DataTable();
            dt = myDAL.GetTable(sql);
            return dt;
        }
      
        public String GetLayMaTK(String tenTK)
        {
            String sql = "select MaTK from tblTaikhoan where Taikhoan = '"+tenTK+"'";
            SqlDataReader dr = myDAL.GetExecuteReader(sql);
            if(dr.Read())
            {
                return dr[0].ToString();
            }
            
            return null;
        }

        //tự tăng mã TK
        public string XuLyMaTK(string matk)
        {
            matk = matk.Remove(0, 2);
            int matkNew = int.Parse(matk) + 1;
            matk = "TK00" + matkNew;
            return matk;
        }
        public string GetMaTKNew()
        {
            string cmdText = "select top 1 MaTK from tblTaikhoan where Chucnang = '2' order by MaTK desc";
            SqlDataReader dataReader = myDAL.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return XuLyMaTK(dataReader[0].ToString());
            }
            return null;
        }

        public string XuLyMaKTV(string maKTV)
        {
            maKTV = maKTV.Remove(0, 3);
            int matkNew = int.Parse(maKTV) + 1;
            maKTV = "KTV00" + matkNew;
            return maKTV;
        }
        public string GetMaKTVNew()
        {
            string cmdText = "select top 1 MaKTV from tblKyThuatVien order by MaKTV desc";
            SqlDataReader dataReader = myDAL.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return XuLyMaKTV(dataReader[0].ToString());
            }
            return null;
        }

    }
}
